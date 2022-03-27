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

