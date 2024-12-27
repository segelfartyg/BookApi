categories = [12,13,14,15,16,17,2,5,6,8,11,177,54,160,161,55,56,57,58,59,60,61,62,63,64,65,66,67,68,27,30,32,33,48,49,50,51,52,53,20,162,22,23,84,85,86,87,88,89,90,91,92,93,94,95,96,97,38,41,43,45,47,98,99,100,101,102,103,105,34,36,37,73,24,155,156,157,158,159,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,165,167,168,170,171,166,172,173,174,175,176]

CategoryCode = ''
CategoryCount = 0

LinkObjectCode = ''
LinkObjectCount = 0

LinkCode = ''
LinkCount = 0

Self = 0
Books = 0
Dynamic = 0

for category in categories:
    LinkObjectCount  = LinkObjectCount + 1
    Self = LinkObjectCount
    LinkObjectCode += 'new LinkObject { Id = ' + str(LinkObjectCount) +', Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categories/' + str(category) +'") },'
    LinkObjectCode += "\n"

    
    LinkObjectCount  = LinkObjectCount + 1
    Books = LinkObjectCount
    LinkObjectCode += 'new LinkObject { Id = ' + str(LinkObjectCount) +', Method = "GET", Title = "Books", Href = new Uri("https://api.bookbeat.com/api/categories/' + str(category) +'/books?offset=0&limit=50") },'

    LinkObjectCode += "\n"
    LinkObjectCount  = LinkObjectCount + 1
    Dynamic = LinkObjectCount
    LinkObjectCode += 'new LinkObject { Id = ' + str(LinkObjectCount) +', Method = "GET", Href = new Uri("https://api.bookbeat.com/api/categoryviews/' + str(category) +'?offset=0&limit=50") },'
    LinkObjectCode += "\n"

    LinkCount = LinkCount + 1
    LinkCode += 'new Links{Id = ' + str(LinkCount) + ', SelfId = ' + str(Self) + ', BooksId = ' + str(Books) + ', DynamicContentId = ' + str(Dynamic) + ', CategoryId = ' + str(category) + '},'
    LinkCode += "\n"
    

    CategoryCode += 'new Category { Id = ' + str(category) + ', Image = new Uri("https://google.se"), Title = "CATEGORY" },'
    CategoryCode += "\n"
    
print(LinkObjectCode)
print("\n\n")
print(LinkCode)
print("\n\n")
print(CategoryCode)