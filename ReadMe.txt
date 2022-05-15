---------------------------------------------------------------25.03.22-----------------------------------------------------
MyNotes.BusinessLayer'ýn içine Test classý olusturup ctorun icine kod yazýldý ( öncesinde add reference yapýp dataaccesslayer ve entitylayer eklendi)
MyNotes.MVC adýnda yeni proje olusturup .ASPNET Web Application seçip ordan MVC olaný seçip olusturduk
MyNotes.MVC Ye references'in içine add reference EntityLayer BusinessLayer eklendi
web.config'in icine connectionstring yazýldý
EntityFramework nuGet'ten eklendi
HomeController içine test'i newledik
WebApp silindi ve MyNotes.MVC start as project yapýp calýstýrdýk ve db olustu
DataAccessLayer'a nugetten fakedata eklendi
DataAccessLayer'a MyInitializer isminde class olusturup db olusturulurken ilk kayýt eklenmesi icin saðlandý ( admin kaydý ve stduser) 
daha sonrasýnda for ile 8 tane daha user kaydý fakedata ile kaydedildi
Ve forlarla fakedatalarla one to many olan iliskili kayýtlardan one dan baþlayarak manylere doðru forlarla kayýt atýldý
ICollectionlý olan kýsýmlarý List olarak deðiþtirdik
---------------------------------------------------------------28.03.22-----------------------------------------------------
Bugün repository patterni iþleyeceðiz.CRUD mekanizmasini tek bi yerden kontrol etmek için kullanýlýr.Önce IRepository þeklinde soyut olusturulur ve sonrasýnda Repository sekline dönüþtürülür
MyNotes.CoreLayer adýnda project ekledik ve interface olarak IRepository ekledik
Ayrý ayrý bütün commentler için sýnýf olusturmak yerine generic yapýlarý kullanarak <T> þeklinde kullanacaðýz
içine kodlarý yazýldý
Somutlaþtýrmak için DataAccessLayer'da class olusturup adýna Repository dedik
sonra interfaceden miras aldýðýmýz için referansý ekledikten sonra implementasyonu gerçekleþtirdik ve kodlarý yazdýk
solid'in nesneleri tek defa türetme kuralýna göre DataAccessLayerde BaseRepository class olusturduk
Kodlar yazýldý
Sonrasýnda MyNotes.MVC'ye Controllers kýsmýna Add Controllers CategoryController eklendi
Direk Controllera gitmemek için BusinessLayer'ý araya sokarak direk iþlem yapmamak için BusinessLayer ManagerBase kullandýk 
Bunu direk controllerdanda kullanabilirdik ama amaç controllerýn iþ yükünü businesslayer'da yaptýrmak
MyNotes.BusinessLayer'a CategoryManager classý açtýk
CategoryController'a  Index'e add view ekledik
View'in içine kodlar yazýldý
Shared->Layout'ýn içine hocanýn kodlarý yapýstýrýldý
Scripts->script.js(wpda) yollandý -- zortladýk býraktýk
Sonra bi link gönderdi onu freedownload yaptýk sonra Content'in içine style.css Scripts'in içine script.js eklendi sonra html dosyasýný sürekleyip layouttaki renderbody alýp html dosyasýndaki section kýsmýný silip oraya yerleþtirip tekrar layout'a alýp programý çalýstýrdýk
---------------------------------------------------------------29.03.22-----------------------------------------------------
Layoutta bir takým düzenlemeler Header kýsmýný düzenledik dropdownlarý ayarladýk vs
Sharedin içine _PartialCategories olarak partial view açtýk çünkü layout içindeki kod kalabalýðýný engelleyerek partiallara ayýrdýk
_PartialFooter isimli bir view açýk footer kýsmýný oraya taþýdýk
_PartialNav isimli bir view açýk footer kýsmýný oraya taþýdýk
CommandManager,LikedManager,NoteManager olusturuldu
Sonuclarýmýn döneceði bir BusinessLayerResult olusturuldu
MyNotesEntityLayer içine Messages folderýnýn içine ErrorMessageCode,ErrorMessageObj olusturuldu biri kodlarý taþýyacak diðeri bunu obje olarak taþýr
Home-index içi silindi ve dün indirdigimiz index kýsmýndan bi part alýndý ve bir component merkezde gözüktü ve içerisi epey dolduruldu düzenlendi
 ---------------------------------------------------------------31.03.22-----------------------------------------------------
MyNotes.MVC sað týk-add asp.net folder APP_code eklendi ve içine Bootstrap view ekledik
Kodlarýn kýsa güzekmesi için helper olarak yazmamýz gerekir
Bootstrap-->docs-->modal kodu kopyala yapýp kodu alýp bootstrap.cshtml'e yapýstýrdýk ve deðiþtirdik
id yi kullanmamýzýn sebebi her kayýt için farklý body olacaðýndan onu yakalamak amacýyla yazdýk ve js'de kullanacaðýmýz için kullandýk
bu kodu calýstýrmamýz için Home-->Index'in alt tarafýna bootstrap ve jquery güncelleyip alt kýsmýna script dosyasýný ekledik
References kýsmýna DataAccessLayer'ý Referans olarak ekledik ve Controllers'a Add Controller yapýp EntityFrameWorklu olan kýsmý seçip Yukarýda Comment seçip alttaki nide seçip olusturuduk
fakat bu neye yorum yapacaðýmý göstermedigimden yapýyý degistireceðiz index'e gittik
altýna jQuery komutlarýný yazdýk $ ile baþlar
Yorumlarýn içini göstermemiz için bi tasarým olusturmamýz lazým bunun icinde partialView olusturmamýz lazým
Olusturduk ve CommentControllerin içinde note üzerinden ilerlendi örn. idsi 1 olan notun 10 yorumu var idsi 2 olan notun 5 yorumu var gibi...
PartialComments'in içine html kodlarý yazýldý
BusinessLayer'a MyNotesUserManager classý açtýk
MyNotesUser'daki bütün degiskenleri istemedigim icin entitylayerda valueobject folderý ve loginviewmodel classý acýp 2 tanesini tanýmladýk
HomeController'a gerekli düzenlemeler yapýldý
Sonra Login Viewini olusturup html kodlarýný yazdýk
---------------------------------------------------------------01.04.22-----------------------------------------------------
Ýsmimizin sað üstte gözükmesi için PartialNav ve Layout kodlarý düzenlendi
HomeController'da LogOut ActionResultý yazýlýp PartialNav'da sonra Cýkýs'ýn href'ine eklendi
Login sayfasýndayken category,footer ve header kýsmý gözükmemesi için JQuery ile Login sayfasýnýn altýna manipüle edilen kodlar yazýldý
Sonrasýnda bootstrap kodlarýyla kutucuk merkeze taþýndý ve resim eklendi
EntityLayer kullanmamak için businesslayer'a modelsê currentsession açýlýp içine kod yazýldý ve partialnavda kullanýldý çalýstý
sonra currentsessionda yer alan kod sadece login session için geçerli genelleþtirmek için kod degistirildi(HomeControllerda bi kýsým degistirildi)
HomeControllerda LogOut a CurrentSession clasýnýn metodu clearlanarak eklendi
HomeControllerda Register ActionResultý yazýlýp Add View Yapýldý ve ValueObject içine RegisterViewModel açýldý
Ýçine Kodlar yazýldý sonra Register Viewýný doldurduk ve Sayfayý kullanýlabilir hale getirdik
Sonra Login.RegisterStyle.css Contentin içine acýp css kodlarýný yazdýk ve login,register viewýnýn içine linkini hrefledik
---------------------------------------------------------------04.04.22-----------------------------------------------------
PartialComments'e kodlar eklendi ( sadece ilgili notun yorumlarý gözükmesi için)
Giris Yapýldýgýnda Yorumlara Týklandýgýnda Yorumunuz açýlmasý gönder butonu eklenmesi saðlandý
CommentController degistirildi
Index htmlin altýna jquery kodlarý yazýldý
MyNotes.Common diye katman olusturduk(Amacýmýz update yaptýgýmýz zaman yorumun username'i system diye degismesi sorununu çözmek)
ICommon diye interface açtýk içine sonra DefaultCommon diye class açýp interface'i içine implemente ettik
App diye bir class olusturduk içinde bir nesne olusturduk 
ve MVC'nin içine Inýt diye kalsör açýp içine WebCommon diye class açýp içine kodlar yazýldý 
Ardýndan Global.asaxda metodu çalýstýrdýk
Repository'e gidip Update kýsmýný deðiþtirdik
---------------------------------------------------------------06.04.22-----------------------------------------------------
Silme,yorum ekleme iþlemi için ajax ve jquery kodlarý yazýldý antiforgery silmeyi unutma.
Register iþlemleri için HomeController ActionResult ve MyNotesUserManager dolduruldu
Helper folderýnýn içine ConfigHelper MAilhelper olusturuldu
Sonra Web.configin içine bazý key-value pairleri tanýmlandý(aktivasyon kodu göndermek için)
ConfigHelper'a metod yazýldý
MailHelper 'a metodlar yazýldý
Sonra ActionResult tamamen bitirildi
---------------------------------------------------------------07.04.22-----------------------------------------------------
Mail geliyor fakat linke týklandýgýnda karþýlamamýz gerek
MVC ye ViewModel açýldý içine NotifyViewModelBase(gelecek her hatayý karþýlayacak)
içine ihtiyacýmýz olan fieldlarý olusturduk
ViewModel folderýna OkViewModel olusturup ctor'unda Title'ýn deðistirdik 
HomeControllerda Register'ýn Postunun metodunun içini deðiþtirdik ve RegisterOk diye ActionResult olusturduk
Sonra RegisterOk View ardýndan Ok View yazýldý
HomeControllerda ActivateUser AR yazýldý sonra MyNotesUserManager'a gidip Metodu yazýldý
Sonra HomeControllerda UserActivateCancel  ve UserActivateOk AR leri ve sonra Viewleri yapýldý
Sayfamdaki bir kategoriye týkladýgýmda o kategoriye ait notlar gelsin
Bunun için HomeControllerda ByCategoryId AR'si yazýldý fakat Index'e Model gönderdiðimizde sýkýntý bütün yorumlarý gösterememesi oldugu için HomeControllerda Index AR'si deðiþtirildi




