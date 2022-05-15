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



