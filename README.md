# CSharpBestPractices

What are Best Practices?
* Consistent look to the code
* Understand code quickly
* Facilitate copying, changing and maintaining the code

When to use tehm?
* Most of the time, but, always should be better!

Do:
* Use PascalCasing and a meaningful name
* Add XML doc comments
* Use properties
* Well defined purpose
* One class per code file
* Add properties above methods
* Provide default constructor
* Consider parameterized constructor
* Name parameters the same name related properties


Don't
* Use prefixes, underscores or abbreviations in names
* Large classes
* Perform too much work at constructor


- Namespaces
Do: 
Follow the format - Company.Technology.Feature
Ex - Microsoft.Media.Design
* Use PascalCasing

Don't
* Use 'system'
* Use class name


- Static Classes
Do:
* Use static classes sparingly
* Use for common utilities

Don't:
* Use as a randon bucket


- Singleton
Do:
* Use when you only need one instance
* Use when you need to create 'child objects'
*  Use to support OOP features

Don't:
* Use if you won't leverage any of the aformentioned features



- Method Overloading
Do:
* Include comments for the method and parameters
* Use few parameters
* Order the parameters consistently

Don't
* Use overloads with same names but different purpose
* Duplicate code



- Method Chaining
Do:
* Implement to reduce repeated code

Don't
* Use if it's overkill and complicating things




- Constants VS Read-Only Fileds

Constant:
Compiled time constant
Assigned on declaration
Only number, boolean or string
Always static


Read-Only:
Runtime constant
Assigned on declaration or constructor
Any data type
Optionally static


Do:
* Define meaningful names
* Use PascalCasing
* Use constants for compile time
* Use read only for runtime


Don't:
* Use uppercase/abbreviations
* Use for fields with values changing



- Properties
Provides flexible mechanism to do the following to private fields:
Read
Write
Compute its value
Think of them as accessors providing access to data with safety and flexibility


Do:
* Use relevant names
* Use 'getter' for simple protection, formating and initializing
* Use 'setter' for simple protection, formating and validation


Don't
* Abbreviate names
* Use complex logic appropriate for methods


- Auto-Implemented Properties
Do:
* Use relevant names
* Initialize the property when needed


Don't:
* Abbreviate names
* Use logic that's better suited for getters and setters


- Related Object Instantiation
Instantiation scenarios:
* Needed once? Use a method!
* Needed alwayas? Use a constructor!
* Needed sometimes? Use property getter to lazy load!



References:
c-sharpcorner
w3schools
sqlauthority
stackoverflow
.Net Rocks
Microsoft.com