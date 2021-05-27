# Model View Presenter
Basic Information:
1- Every View have a presenter (take as a highly specialized controller) <BR>
2- There are two variants of MVP<BR>
	- Passive View<BR>
	- Supervising Controller<BR>
3- Passive View<BR>
	- Presenter communicate with View using Interface<BR>
	- For each view item property, user need to define a separate interface property<BR>
		For Example: for Textbox -> Text, Visible, Enabled, Font Color
		need to define separate property in interface<BR>
	- Presenter has to do a lot of work with Model and View (having almost same properties) <BR>
	- View have to fetch data from Presenter, as Presenter is responsible to fetch date from DAL<BR>
	- So there are more cons of using Passive View<BR>
4- Supervising Controller<BR>
	- Views are smarter in Supervising Controller Pattern<BR>
	- They know what to do with the information provided by the Presenter<BR>
	- Interface implements the Model object as property, rather view items as properties (as in Passive View) <BR>
	- In view, interface implementation required bit more work, however it seems more neat code in the end<BR>

