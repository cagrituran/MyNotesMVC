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

