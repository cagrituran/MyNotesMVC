﻿using MyNotes.BusinessLayer.Abstract;
using MyNotes.BusinessLayer.ValueObject;
using MyNotes.Common.Helper;
using MyNotes.EntityLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes.BusinessLayer
{
    public class MyNotesUserManager : ManagerBase<MyNotesUser>
    {
        //Kullanıcı username kontrolu yapmalıyım
        //Kullanici emaili kontrolu yapmalıyım
        //Kayit islemi gerceklestirmeliyim
        //activation e-posta gonderiimi
        private BusinessLayerResult<MyNotesUser> res = new BusinessLayerResult<MyNotesUser>();
        public BusinessLayerResult<MyNotesUser> LoginUser(LoginViewModel data)
        {
            res.Result = Find(s => s.UserName == data.UserName && s.Password == data.Password);
            if (res.Result != null)
            {
                if (!res.Result.IsActive)
                {
                    res.AddError(EntityLayer.Messages.ErrorMessageCode.UserIsNotActive, "Kullanici adi aktiflestirilmemis...");
                    res.AddError(EntityLayer.Messages.ErrorMessageCode.CheckYourEmail, "Lutfen mailinizi kontrol ediniz!");
                }


            }
            else
            {
                res.AddError(EntityLayer.Messages.ErrorMessageCode.UsernameOrPassWrong, "Kullanici adi yada sifreniz yanlis lutfen kontrol edin...");
            }
            return res;

        }
        public BusinessLayerResult<MyNotesUser> RegisterUser(RegisterViewModel data)
        {
            MyNotesUser user = Find(s => s.UserName == data.Username || s.Email == data.Email);
            if (user != null)
            {
                if (user.UserName == data.Username)
                {
                    res.AddError(EntityLayer.Messages.ErrorMessageCode.UserNameAlreadyExist, "Bu kullanici adi daha once alinmis");
                }
                if (user.Email == data.Email)
                {
                    res.AddError(EntityLayer.Messages.ErrorMessageCode.EmailAlreadyExist, "bu email daha once kullanilmis");
                }
            }
            else
            {
                int dbResult = base.Insert(new MyNotesUser()
                {
                    Name = data.Name,
                    LastName = data.Lastname,
                    Email = data.Email,
                    UserName = data.Username,
                    Password = data.Password,
                    IsActive = false,
                    IsAdmin = false,
                    ActivateGuid = Guid.NewGuid(),
                });
                if (dbResult > 0)
                {
                    res.Result = Find(s => s.Email == data.Email && s.UserName == data.Username);
                    //Activasyon Maili Gonderilecek
                    string siteUri = ConfigHelper.Get<string>("SiteRootUri");
                    string activateUri = $"{siteUri}/Home/UserActivate/{res.Result.ActivateGuid}";
                    string body = $"Merhaba {res.Result.UserName};<br><br> Hesabinizi aktiflestirmek icin <a href='{activateUri}' target='_blank'>bu linke tiklayin</a>.";
                    MailHelper.SendMail(body, res.Result.Email, "My Notes Activation Mail Hizmeti");
                }
            }
            return res;
        }
    }
}