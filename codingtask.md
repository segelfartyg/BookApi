## BookBeat Code Task

### Summary

Your task is to develop a dotnet api that presents categories similar to BookBeat's production environment.

### Scope

The focus should be on writing code for the categories api.
Well structured code with a few bonus tasks solved is much better than all bonus tasks solved with a very messy code.
Books & Dynamic Content are out of scope.

### Task

BookBeat have some endpoints that can be accessed unauthenticated. Categories is one of them.
Develop a dotnet api that presents all categories similar to the sample.
The entry point for the categories api is:
https://api.bookbeat.com/api/categories

#### Code submision

Create a repository on GitHub and email the link to us.

### Tips

You do not have to replicate the format in detail, if you want to make structural or architectural changes, you are welcome to.
You can use the BookBeat web https://www.bookbeat.com/se/kategorier or the iOS / Android app to get a better understanding of how the categories api is used by client apps.
The API uses HAL(Hypertext Application Language) for links https://stateless.group/hal_specification.html. You do not need to use HAL.
You are allowed to use GPT or other LLMs to generate code, but you need to be able to explain the code in detail.
Categories have children, that can have children

#### Bonus Tasks (not ordered by difficulty)

Create a new category
Delete a category
Update a category
Use a real (dockerized?) database
Add caching
Add unit tests
Add api integration tests
Use a distinct architectural pattern througout the api
Package the api for deployment
readme / documentation

### Json Data models

A simplified category model looks something like this.

```json
{
  "_links": {
    "self": {
      "href": "https://api.bookbeat.com/api/categories",
      "method": "GET"
    }
  },
  "_embedded": {
    "categories": [
      {
        "id": 38,
        "image": "https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_30.png?format=png&quality=75&w=450",
        "title": "Personal Development",
        "description": "",
        "parentid": null,
        "_links": {
          "self": {
            "href": "https://api.bookbeat.com/api/categories/38",
            "method": "GET"
          },
          "books": {
            "href": "https://api.bookbeat.com/api/categories/38/books?offset=0&limit=50",
            "title": "Books",
            "method": "GET"
          },
          "dynamiccontent": {
            "href": "https://api.bookbeat.com/api/categoryviews/38?offset=0&limit=50",
            "method": "GET"
          }
        },
        "_embedded": {
          "children": [
            {
              "id": 41,
              "image": "https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_51.png?format=png&quality=75&w=450",
              "title": "Family Life & Relations",
              "description": "",
              "parentid": 38,
              "_links": {
                "self": {
                  "href": "https://api.bookbeat.com/api/categories/41",
                  "method": "GET"
                },
                "books": {
                  "href": "https://api.bookbeat.com/api/categories/41/books?offset=0&limit=50",
                  "title": "Books",
                  "method": "GET"
                },
                "dynamiccontent": {
                  "href": "https://api.bookbeat.com/api/categoryviews/41?offset=0&limit=50",
                  "method": "GET"
                }
              },
              "_embedded": {
                "children": []
              }
            },
            {
              "id": 43,
              "image": "https://prod-bb-images.akamaized.net/categories-covers/cat/img_cat_94.png?format=png&quality=75&w=450",
              "title": "Psychology",
              "description": "",
              "parentid": 38,
              "_links": {
                "self": {
                  "href": "https://api.bookbeat.com/api/categories/43",
                  "method": "GET"
                },
                "books": {
                  "href": "https://api.bookbeat.com/api/categories/43/books?offset=0&limit=50",
                  "title": "Books",
                  "method": "GET"
                },
                "dynamiccontent": {
                  "href": "https://api.bookbeat.com/api/categoryviews/43?offset=0&limit=50",
                  "method": "GET"
                }
              },
              "_embedded": {
                "children": []
              }
            }
          ]
        }
      }
    ]
  }
}
```
