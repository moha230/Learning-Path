# Dictionaries 

The dictionary is located in the system Collection generic namespace 

* data in the dictionary is stored as key value pairs.
* where value can be added retrieved and deleted using keys  

**`Dictionary<string, string> postalCodes = new Dictionary<string, string>();`**

The first is the collection type `Dictionary`

`<string,string>` this specifies the type for the key and value 

key is the `string`
value is the `string`

```C#
postalCodes["00100"] = "Helsinki";

```

`postalCode`: is the name of the dictionary variable 

`new Dictionary<string , string>()` : This creates a new instance of the dictionary we have new key word that creates the instance of the class and the initialization of the Dictionary object

The new keyword allocates memory for the dictionary  and calls its constructor to create an empty dictionary.

`<string,string>` 

In summary:

new is used to create a new object.
Dictionary<string, string> specifies the type of object being created.
The () after the Dictionary class name means the default constructor is being used to create an empty dictionary.


two types of parameters are need when creating a dictionary 

The type of key and the type of value added 
if key is type of string and value of type os integer 

The  dictionary  will be created in the following statement 

```C#
Dictionary<string,integer> chickens = new Dictionary<string, integer>();
```

to add values to a dictionary we use the add method 

```C#
chickens.Add("wild",8);
```

retrieving from a dictionary is done using the index access method chickens["wild"];

## Dictionary Keys Correspond to a Single Value at Most


dictionary has one value per key if thenew key is added and there is a key already we get `argumentException`

# A Reference Type Variable as a Dictionary Value


# When Should Dictionaries Be Used?

# Dictionary as an Instance Variable