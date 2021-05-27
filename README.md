# Model View Presenter
Baisc Information:
1- Every View have a presenter (take as a highly specialized controller)
2- There are Two varients of MVP
	- Passive View
	- Supervising Controller
3- Passive View
	- Presenter communicate with View using Interface
	- For each view item property, user need to define a seperate interface property
		For Example: for Textbox -> Text, Visible, Enabled, FontColor 
		need to define seperate property in interface
	- Presenter has to do a lot of work with Model and View (having almost same properties)
	- View have to fetch data from Presenter, as Presenter is responsible to fetch date from DAL
	- So there are more cons of using Passive View
4- Supervising Controller
	- Views are smarter in Supervising Controller Pattern
	- They know what to do with the information provided by the Presenter
	- Interface implements the Model object as property, rather view items as properties (as in Passive View)
	- In view, interface implementation required bit more work, however it seems more neet code in the end
