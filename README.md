# Assignment 2: Prototype Development and Research for Web Application
## Project Overview
This application is a prototype for a climate data-based web application. It aims to help event planners and everyday people plan for future events by providing accurate weather predictions. This project has a home page as well as a search page. It is currently in the prototype phase, meaning not everything has functionality yet. However, the layout is there. 

## Page Description
Two pages were created for the site. One being a home page and the other being used for searching locations. Both use bootstrap and have custom CSS made to enchance the overall look of the application. The bootstrap used was call Mint. The custom CSS can be found in the css/site.css. This CSS sets the background color and adds a blue dotted border around the site. 
### Home Page
The first thing on the home page is a level one heading providing a call to action. Following that is an anchor element that navigates the user from the home page to the search page. This is done by using the (<a>) function with the hypertext reference (here). The next item on the home page is the second-level header. This serves as a title for the table that follows. The table includes reasons why this application can help you. The table has two rows and is styled with stripes, using “table table-striped.” Next on the home page is another level two header. This header is a title for the list that follows. The list is a part of my unique HTML Element that wasn’t discussed in class. I was inspired by other websites that provide lists. This list lists popular destinations. Currently, it is just a list, but in the future, I want to be able to make the list interactive and lead them to search results.
### Search Page

The first code on the search page is a second-level header telling the user to start. Next is another second-level header asking the user to type in the desired location to search for. Then, there is a search bar. This search bar currently is not entirely functional. It, however, lets the user type in the bar. Next is a button created with JavaScript, which future purpose is to search the location typed in the search bar.

## Research Summary


One of the first websites is [Climate Data](https://en.climate-data.org/). Like my future site, this site aims to provide users access to climate data to help the general public plan future events by providing them with climate data to help get them an estimate of what kind of weather they entail. Functions of Climate Data's application include an interactive map that allows you to click on which continents and then takes you to a page with a list of countries and cities in that continent. When you click on the city's name, it brings you to another page. In the URL, a hashtag is used to identify a specific section in a webpage. This page provides information about the climate of each city. One feature that stood out to me was the table that they provided. They used a <tbody> to create a table with different climate scenarios depending on the month. They also add images to show the user what the cities look like and have to offer. This was a nice feature to add to my application. Another feature that stood out to me while inspecting was the usage of Bootstrap. I also noticed the use of headers and colors.

The next application similar to mine is [Visual Crossing](https://www.visualcrossing.com/weather/weather-data-services). This site used a search bar to look up locations using “class=”form-control.” I think I will add a feature like this because finding locations would make it easier for the users to navigate the applications. Another feature would be how the buttons included images to describe what they do. This feature will help users understand what function the button does. Other features I noticed from this application would be bootstrap, borders, and colors.


The third website is another website that gives out free climate data to users, [Climate](https://www.climate.gov/maps-data/all?query=*&us=1). They focus on the United States. Their home page has a map of the United States divided into sections. When clicking on a section, it brings you to another page. When you click on the page, it contains a question mark in the URL. The question mark tells the website what specific information the user is trying to get. One feature that stands out is the container feature that contains specific filters to get the data. This is done by <div class=” container”> the blocks are coded within. Other features would be the use of Bootstrap, lists, and buttons.

The [find-weather-app](https://github.com/AMARDEEP115/find-weather-app) is a git hub repository that is created to a website to show the weather forecast. In the readme of this repositiory it gives you a live preview of the application. This was helpful to see, knowing I can take inspiration to what I would like my application to resemble.The readme then goes on to provided features the site contains. It allows you to use your current location and search the weather by entering a city name. From this repositiory readme I can take away that it can be used in my project by providing useful code snippets and some strucal ideas. For example I am adding a geo location to my site as well. So this repostitory gives me a good example to follow.  


This git hub repository, [WeatherDashboard](https://github.com/kathleendorse/WeatherDashboard) provides a application that uses a search bar for users to look up a city and get information regarding the current and future weather. While looking through the readme they give an description of what the weather dashboard was created for. Its purpose was to provide travelers with the information about the weather they needed to know. The readme provides a live link to the application to look at. It also provides a visualixation of the application. In my project I want to create an application where users can look up there specific city. This repositiory is good to give me strucual ideas that I want to add to my own application as well as some code that could be useful. 


## Future Enchancements
In my future applications, I plan to make the search bar functional. I liked it so that the user is taken to another page with the information for their location. Another potential future advancement would be to make the list on the home page functional. The user could click on the location and have the application bring them to a page with the information needed. On this new page, I would like it to provide users with the climate and a search for specific dates.

# Citations
- [Climate Data](https://en.climate-data.org/)
- [Visual Crossing](https://www.visualcrossing.com/weather/weather-data-services)
- [find-weather-app](https://github.com/AMARDEEP115/find-weather-app)
- [WeatherDashboard](https://github.com/kathleendorse/WeatherDashboard)
- [W3Schools](https://www.w3schools.com/css/css_border_color.asp)
- To construct this assignment, I used [ChatGPT 4](https://chat.openai.com) with the following prompt:
---
 >Add two more properties for this CCS for HTML classes in css/sit.css: background-color: lightblue;

The output gave me more ideas of what I could add to my application. It was a border. Originally, the border was planned, so I took the inspiration from ChatGPT and used w3schools to add more to it, like changing the color and style to dotted.
## Reflection on Resources
To start this project, I used the lecture videos that were posted. The lecture videos, class examples, and my own personal notes were my preferred sources for this project. It helped me get a layout of what I needed for my application. When adjusting or adding other features, I used ChatGPT and W3Schools to search for what I needed. Other resources included the sites listed in the citations. These sites were used to inspire and research what I wanted to include in my application. The challenge I had was finding GIT hubs that were focused on what I was trying to create. Other than that, most information was easy to find

