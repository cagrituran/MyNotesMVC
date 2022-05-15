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



