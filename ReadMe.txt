---------------------------------------------------------------25.03.22-----------------------------------------------------
MyNotes.BusinessLayer'�n i�ine Test class� olusturup ctorun icine kod yaz�ld� ( �ncesinde add reference yap�p dataaccesslayer ve entitylayer eklendi)
MyNotes.MVC ad�nda yeni proje olusturup .ASPNET Web Application se�ip ordan MVC olan� se�ip olusturduk
MyNotes.MVC Ye references'in i�ine add reference EntityLayer BusinessLayer eklendi
web.config'in icine connectionstring yaz�ld�
EntityFramework nuGet'ten eklendi
HomeController i�ine test'i newledik
WebApp silindi ve MyNotes.MVC start as project yap�p cal�st�rd�k ve db olustu
DataAccessLayer'a nugetten fakedata eklendi
DataAccessLayer'a MyInitializer isminde class olusturup db olusturulurken ilk kay�t eklenmesi icin sa�land� ( admin kayd� ve stduser) 
daha sonras�nda for ile 8 tane daha user kayd� fakedata ile kaydedildi
Ve forlarla fakedatalarla one to many olan iliskili kay�tlardan one dan ba�layarak manylere do�ru forlarla kay�t at�ld�
ICollectionl� olan k�s�mlar� List olarak de�i�tirdik
---------------------------------------------------------------28.03.22-----------------------------------------------------
Bug�n repository patterni i�leyece�iz.CRUD mekanizmasini tek bi yerden kontrol etmek i�in kullan�l�r.�nce IRepository �eklinde soyut olusturulur ve sonras�nda Repository sekline d�n��t�r�l�r
MyNotes.CoreLayer ad�nda project ekledik ve interface olarak IRepository ekledik
Ayr� ayr� b�t�n commentler i�in s�n�f olusturmak yerine generic yap�lar� kullanarak <T> �eklinde kullanaca��z
i�ine kodlar� yaz�ld�
Somutla�t�rmak i�in DataAccessLayer'da class olusturup ad�na Repository dedik
sonra interfaceden miras ald���m�z i�in referans� ekledikten sonra implementasyonu ger�ekle�tirdik ve kodlar� yazd�k
solid'in nesneleri tek defa t�retme kural�na g�re DataAccessLayerde BaseRepository class olusturduk
Kodlar yaz�ld�
Sonras�nda MyNotes.MVC'ye Controllers k�sm�na Add Controllers CategoryController eklendi
Direk Controllera gitmemek i�in BusinessLayer'� araya sokarak direk i�lem yapmamak i�in BusinessLayer ManagerBase kulland�k 
Bunu direk controllerdanda kullanabilirdik ama ama� controller�n i� y�k�n� businesslayer'da yapt�rmak
MyNotes.BusinessLayer'a CategoryManager class� a�t�k
CategoryController'a  Index'e add view ekledik
View'in i�ine kodlar yaz�ld�
Shared->Layout'�n i�ine hocan�n kodlar� yap�st�r�ld�
Scripts->script.js(wpda) yolland� -- zortlad�k b�rakt�k
Sonra bi link g�nderdi onu freedownload yapt�k sonra Content'in i�ine style.css Scripts'in i�ine script.js eklendi sonra html dosyas�n� s�rekleyip layouttaki renderbody al�p html dosyas�ndaki section k�sm�n� silip oraya yerle�tirip tekrar layout'a al�p program� �al�st�rd�k
---------------------------------------------------------------29.03.22-----------------------------------------------------
Layoutta bir tak�m d�zenlemeler Header k�sm�n� d�zenledik dropdownlar� ayarlad�k vs
Sharedin i�ine _PartialCategories olarak partial view a�t�k ��nk� layout i�indeki kod kalabal���n� engelleyerek partiallara ay�rd�k
_PartialFooter isimli bir view a��k footer k�sm�n� oraya ta��d�k
_PartialNav isimli bir view a��k footer k�sm�n� oraya ta��d�k
CommandManager,LikedManager,NoteManager olusturuldu
Sonuclar�m�n d�nece�i bir BusinessLayerResult olusturuldu
MyNotesEntityLayer i�ine Messages folder�n�n i�ine ErrorMessageCode,ErrorMessageObj olusturuldu biri kodlar� ta��yacak di�eri bunu obje olarak ta��r
Home-index i�i silindi ve d�n indirdigimiz index k�sm�ndan bi part al�nd� ve bir component merkezde g�z�kt� ve i�erisi epey dolduruldu d�zenlendi
 ---------------------------------------------------------------31.03.22-----------------------------------------------------
MyNotes.MVC sa� t�k-add asp.net folder APP_code eklendi ve i�ine Bootstrap view ekledik
Kodlar�n k�sa g�zekmesi i�in helper olarak yazmam�z gerekir
Bootstrap-->docs-->modal kodu kopyala yap�p kodu al�p bootstrap.cshtml'e yap�st�rd�k ve de�i�tirdik
id yi kullanmam�z�n sebebi her kay�t i�in farkl� body olaca��ndan onu yakalamak amac�yla yazd�k ve js'de kullanaca��m�z i�in kulland�k
bu kodu cal�st�rmam�z i�in Home-->Index'in alt taraf�na bootstrap ve jquery g�ncelleyip alt k�sm�na script dosyas�n� ekledik
References k�sm�na DataAccessLayer'� Referans olarak ekledik ve Controllers'a Add Controller yap�p EntityFrameWorklu olan k�sm� se�ip Yukar�da Comment se�ip alttaki nide se�ip olusturuduk
fakat bu neye yorum yapaca��m� g�stermedigimden yap�y� degistirece�iz index'e gittik
alt�na jQuery komutlar�n� yazd�k $ ile ba�lar
Yorumlar�n i�ini g�stermemiz i�in bi tasar�m olusturmam�z laz�m bunun icinde partialView olusturmam�z laz�m
Olusturduk ve CommentControllerin i�inde note �zerinden ilerlendi �rn. idsi 1 olan notun 10 yorumu var idsi 2 olan notun 5 yorumu var gibi...
PartialComments'in i�ine html kodlar� yaz�ld�
BusinessLayer'a MyNotesUserManager class� a�t�k
MyNotesUser'daki b�t�n degiskenleri istemedigim icin entitylayerda valueobject folder� ve loginviewmodel class� ac�p 2 tanesini tan�mlad�k
HomeController'a gerekli d�zenlemeler yap�ld�
Sonra Login Viewini olusturup html kodlar�n� yazd�k
---------------------------------------------------------------01.04.22-----------------------------------------------------
�smimizin sa� �stte g�z�kmesi i�in PartialNav ve Layout kodlar� d�zenlendi
HomeController'da LogOut ActionResult� yaz�l�p PartialNav'da sonra C�k�s'�n href'ine eklendi
Login sayfas�ndayken category,footer ve header k�sm� g�z�kmemesi i�in JQuery ile Login sayfas�n�n alt�na manip�le edilen kodlar yaz�ld�
Sonras�nda bootstrap kodlar�yla kutucuk merkeze ta��nd� ve resim eklendi
EntityLayer kullanmamak i�in businesslayer'a models� currentsession a��l�p i�ine kod yaz�ld� ve partialnavda kullan�ld� �al�st�
sonra currentsessionda yer alan kod sadece login session i�in ge�erli genelle�tirmek i�in kod degistirildi(HomeControllerda bi k�s�m degistirildi)
HomeControllerda LogOut a CurrentSession clas�n�n metodu clearlanarak eklendi
HomeControllerda Register ActionResult� yaz�l�p Add View Yap�ld� ve ValueObject i�ine RegisterViewModel a��ld�
��ine Kodlar yaz�ld� sonra Register View�n� doldurduk ve Sayfay� kullan�labilir hale getirdik
Sonra Login.RegisterStyle.css Contentin i�ine ac�p css kodlar�n� yazd�k ve login,register view�n�n i�ine linkini hrefledik
---------------------------------------------------------------04.04.22-----------------------------------------------------
PartialComments'e kodlar eklendi ( sadece ilgili notun yorumlar� g�z�kmesi i�in)
Giris Yap�ld�g�nda Yorumlara T�kland�g�nda Yorumunuz a��lmas� g�nder butonu eklenmesi sa�land�
CommentController degistirildi
Index htmlin alt�na jquery kodlar� yaz�ld�
MyNotes.Common diye katman olusturduk(Amac�m�z update yapt�g�m�z zaman yorumun username'i system diye degismesi sorununu ��zmek)
ICommon diye interface a�t�k i�ine sonra DefaultCommon diye class a��p interface'i i�ine implemente ettik
App diye bir class olusturduk i�inde bir nesne olusturduk 
ve MVC'nin i�ine In�t diye kals�r a��p i�ine WebCommon diye class a��p i�ine kodlar yaz�ld� 
Ard�ndan Global.asaxda metodu �al�st�rd�k
Repository'e gidip Update k�sm�n� de�i�tirdik
---------------------------------------------------------------06.04.22-----------------------------------------------------
Silme,yorum ekleme i�lemi i�in ajax ve jquery kodlar� yaz�ld� antiforgery silmeyi unutma.
Register i�lemleri i�in HomeController ActionResult ve MyNotesUserManager dolduruldu
Helper folder�n�n i�ine ConfigHelper MAilhelper olusturuldu
Sonra Web.configin i�ine baz� key-value pairleri tan�mland�(aktivasyon kodu g�ndermek i�in)
ConfigHelper'a metod yaz�ld�
MailHelper 'a metodlar yaz�ld�
Sonra ActionResult tamamen bitirildi
---------------------------------------------------------------07.04.22-----------------------------------------------------
Mail geliyor fakat linke t�kland�g�nda kar��lamam�z gerek
MVC ye ViewModel a��ld� i�ine NotifyViewModelBase(gelecek her hatay� kar��layacak)
i�ine ihtiyac�m�z olan fieldlar� olusturduk
ViewModel folder�na OkViewModel olusturup ctor'unda Title'�n de�istirdik 
HomeControllerda Register'�n Postunun metodunun i�ini de�i�tirdik ve RegisterOk diye ActionResult olusturduk
Sonra RegisterOk View ard�ndan Ok View yaz�ld�
HomeControllerda ActivateUser AR yaz�ld� sonra MyNotesUserManager'a gidip Metodu yaz�ld�
Sonra HomeControllerda UserActivateCancel  ve UserActivateOk AR leri ve sonra Viewleri yap�ld�
Sayfamdaki bir kategoriye t�klad�g�mda o kategoriye ait notlar gelsin
Bunun i�in HomeControllerda ByCategoryId AR'si yaz�ld� fakat Index'e Model g�nderdi�imizde s�k�nt� b�t�n yorumlar� g�sterememesi oldugu i�in HomeControllerda Index AR'si de�i�tirildi




