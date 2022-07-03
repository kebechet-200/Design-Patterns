# ზოგადი პრობლემის აღწერა

  ხანდახან არის მომენტები როდესაც ბიზნესი გვაძლევს დავალებას (კონკრეტულს) მაგალითისთვის: ბიზნესმა მოგვცა დავალება რომ დელივერის სერვისი უნდა განხორციელდეს სახმელეთო
გზით. ამ ფუნქციონალის შექმნის შემდეგ ბიზნესი განვითარდა და ახლა სურთ რომ დაამატონ საზღვაო დელივერი სერვისი. ეს როგორც ბიზნესური მხარე რთული არ ჩანს. თუმცა როგორც
დეველოპმენტი საკმაოდ ფუნდამენტურ ცვლილებებს იწვევს ჩვენს კოდში, რადგან ჩვენი კოდი მუშაობს მხოლოდ სახმელეთო დელივერი სერვისისთვის და მთელი ფუნქციონალი მოთავსებული
გვაქვს სახმელეთო დელივერის ბიზნეს ლოგიკაში. ამ შემთხვევაში არსებობს გამოსავალი რომ შევქმნათ ახალი ფუნქციონალი 0-დან რომელსაც ბევრი საერთო ექნება სახმელეთო ფუნქციონალთან.

ეს გარკვეულ წილად იწვევს ბოილერფლეით კოდს. (boilerplate-განმეორებადი კოდი პატარა ცვლილებებით, ან სულაც უცვლელი.) რომელიც არის ცუდი პრაქტიკა და ხშირია ჯუნიორ 
პროგრამისტებში. 

## გამოსავალი

  გამოსავალი არის Factory Method, რომელიც ქმნის სუპერ კლასს რომელსაც აქვს აბსტრაქტული მეთოდი. მისი დაქვემდებარებული ყველა კლასი თავის მხრივ იიმპლემენტირებს ამ მეთოდს,
მაგალითად : გვაქვს სუპერ კლასი დელივერი სადაც არის ზოგადი ფუნქციონალი გაწერილი, ხოლო ფუნქციონალი რომელიც არის კონკრეტული თითოეული დელივერი მეთოდისთვის არის
აბსტრაქტული და ყველა კლასს აიძულებს მისეულ იმპლემენტაციას.
  
  
  ## გამოყენება
  ეს პატერნი გამოიყენება მაშინ როდესაც წინასწარ ბიზნესისგან არ იცით ობიექტის ზუსტი ტიპები და შეიძლება იყოს მოლოდინი რომ ობიექტის დამოკიდებულებები შეიცვალოს სამომავლო 
ბიზნეს გეგმებიდან გამომდინარე
  
ჩვენს შემთხვევაში პროდუქტი და პროდუქტის შემქმნელი ნაწილი არის გამოყოფილი (შექმნილია ცალკე class library-ები რომელსაც ზოგადი dependency აქვთ ერთმანეთთან )
ამიტომ მარტივია პროდუქტის შემქმნელ კლასში ცვლილებების შეტანა და განხორციელება პროდუქტის კლასის დამოუკიდებლად
  
მაგალითად თუ შევქმნით ახალ პროდუქტს, ჩვენ მხოლოდ დაგვჭირდება შევქმნათ ახალი პროდუქტის შემქმნელი ქვე კლასი რომელიც დაიიმპლემენტირებს CreateProduct() მეთოდს.
  
  
  ## დადებითი და უარყოფითი მხარეები
  1. ✅თქვენ თავიდან აიცილებთ მჭიდრო კავშირს პროდუქტსა და პროდუქტის შემქმნელ კლასებს შორის
  2. ✅იცავს Single Responsibility Principle
  3. ✅იცავს Open/Closed პრინციპს. თქვენ შეგიძლიათ შემოიტანოთ ახალი ტიპის პროდუქტები ძველის შეცვლის გარეშე.
  
  1. ❌კოდი შეიძლება გართულდეს რადგან პატერნის განსახორციელებლად საჭიროა ბევრი ქვე კლასების შექმნა. საუკეთესო შემთხვევა არის როცა პატერნს ნერგავთ შემქმნელი კლასის
  იერარქიაში
  
  