using MyNotes.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes.DataAccessLayer
{
    public class MyInitializer:CreateDatabaseIfNotExists<MyNoteContext>
    {
        protected override void Seed(MyNoteContext context)
        {
            MyNotesUser admin = new MyNotesUser()
            {
                 Name = "Cagri",
                 LastName = "Turan",
                 Email = "cagri.turann@hotmail.com",
                 IsActive = true,
                 IsAdmin = true,
                 UserName = "cagrituran",
                 Password = "1234",
                 CreatedOn = DateTime.Now,
                 ModifiedOn = DateTime.Now,
                 ModifiedUserName = "system"
            };

            MyNotesUser stduser = new MyNotesUser()
            {
                Name = "raf",
                LastName = "baf",
                Email = "cta",
                IsActive = true,
                IsAdmin = false,
                UserName = "cfs",
                Password = "1234",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUserName = "system"
            };
            context.MyNotesUsers.Add(admin);
            context.MyNotesUsers.Add(stduser);

            for (int i = 0; i < 8; i++)
            {
                MyNotesUser user = new MyNotesUser()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    LastName = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    IsActive = true,
                    IsAdmin = false,
                    UserName = $"user-{i}",
                    Password = "123",
                    CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1),DateTime.Now),
                    ModifiedOn =  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedUserName =  $"user-{i}",

                };
                context.MyNotesUsers.Add(user);
            }

            context.SaveChanges();
            List<MyNotesUser> userList =context.MyNotesUsers.ToList();
            for (int i = 0; i < 10; i++)
            {
                //Adding Categories
                Category cat = new Category()
                {
                    Tittle = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn =  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedOn =  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedUserName = "system"

                };
                context.Categories.Add(cat);
                //Adding Notes
                for (int j = 0; j < FakeData.NumberData.GetNumber(5,9); j++)
                {
                    MyNotesUser owner = userList[FakeData.NumberData.GetNumber(0, userList.Count-1)];
                    Note note = new Note()
                    {
                        Tittle = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5, 25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1,3)),
                        isDraft = false,
                        LikeCount = FakeData.NumberData.GetNumber(1,9),
                        Owner = owner,
                        CreatedOn =  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedOn=  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUserName = owner.UserName,

                    };
                    context.Notes.Add(note);
                    //Adding Comment
                    for (int k = 0; k < FakeData.NumberData.GetNumber(3,5); k++)
                    {
                        MyNotesUser comment_owner = userList[FakeData.NumberData.GetNumber(0,userList.Count-1)];
                        Comment comment = new Comment()
                        {
                            Text = FakeData.TextData.GetSentence(),
                            Owner = comment_owner,
                            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn =  FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedUserName = comment_owner.UserName,


                        };
                        context.Comments.Add(comment);
                    //Adding Like
                    }
                    context.SaveChanges();
                    for (int k = 0; k < note.LikeCount; k++)
                    {
                        Liked liked = new Liked()
                        {
                            LikedUser = userList[k],

                        };
                        context.Likes.Add(liked);

                    }
                }


            }
           
            context.SaveChanges();
        }
    }
}
