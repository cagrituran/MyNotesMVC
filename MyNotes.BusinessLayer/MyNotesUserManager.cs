using MyNotes.BusinessLayer.Abstract;
using MyNotes.BusinessLayer.ValueObject;
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
    }
}