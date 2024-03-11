<!-- 
---------------------------------------------------------------------------------------------------------------------------------------------------------

<HTML Page Structure>

// this is the type of html you are using
// Note: html type do not have closing tag
<!DOCTYPE html>

// this is the language prefer of HTML and also the head tag
<html lang="en">

    // this is the heading or the head tag of the html
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        // this is the title tag
        <title>Document</title>
    </head>
    // this is the closing tag of the head tag

    // this is the body or the body tag of the html
    <body>

    </body>
    // this is the closing tag of the body tag

</html>
// this is the closing tag of the html tag

</HTML Page Structure>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Add a title for your website>

    // add title inside your head tag
    <head>
        <title>add name for your title</title>
    </head>

</Add a title for your website>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Comments in HTML>

// use <!-- --> tag to create a comments inside your html file
<!-- 
    this is your comment
-->

// you can also use comments for debugging in html file
<!--
    <p>this is your tag you want to remove temporarily</p>
-->

</Comments in HTML>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Paragraph>

    // use p tag to create a paragraph on your website
    <p>this is your Paragraph</p>

</Paragraph>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Headings>
---------------------------------------------------------------------------------------------------------------------------------------------------------
// h1 tag is the largest headings
// h2 tag is the second to the largest headings
// h3 tag is the third to the largest headings
// h4 tag is the fourth to the largest headings
// h5 tag is the fifth to the largest headings
// h6 tag is the smallest headings

    // add headings inside the body tag
    <body>

        // use h1 to create a heading in your website
        <h1>this is your heading 1 tag</h1>
        
        // use h2 to create a heading in your website
        <h2>this is your heading 2 tag</h2>

        // use h3 to create a heading in your website
        <h3>this is your heading 3 tag</h3>

        // use h4 to create a heading in your website
        <h4>this is your heading 4 tag</h4>

        // use h5 to create a heading in your website
        <h5>this is your heading 5 tag</h5>

        // use h6 to create a heading in your website
        <h6>this is your heading 6 tag</h6>

    </body>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Headings>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<break element>
    
<body>

    // use br tag to create a break or a next line between words
    // Note: break tag do not have closing tag
    <p> Hello <br> World!!!</p>

    // you can also use br tag to create a break or a next line between tags
    <p> Hello World!!!</p>
    <br>
    <p> Hello Globe!!!</p>

</body>

<break element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------------------------------
<Text Formatting Elements>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Bold>

<body>

    // Note: use can use this Formatting Elements inside a tag

    // use b tag to create a bold format inside the html file
    <b>this is your Bold Format</b>

</body>

</Bold>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Important>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use strong tag to create an Important format inside the html file
    <strong>this is your Important Format</strong>

</body>

</Important>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Italic>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use i tag to create an italic format inside the html file
    <i>This is your Italic Format</i>

</body>

</Italic>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Emphasized>

<body>

    // Note: use can use this Formatting elements inside a tag
    
    // use em tag to create an Emphasized format inside the html file
    <em>This is your Emphasized Format</em>

</body>

</Emphasized>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Marked>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use mark tag to create a Marked format inside the html file
    <mark>This your Marked Format</mark>

</body>

</Marked>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Smaller>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use small tag to create a smaller format inside the html file
    <small>This is your Smaller Format</small>

</body>

</Smaller>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Deleted>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use del tag to create a deleted format inside the html file
    <del>This is your Deleted Format</del>

</body>

</Deleted>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Inserted>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use ins tag to create a inserted format inside the html file
    <ins>This is your Inserted Format</ins>

</body>

</Inserted>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Subscript>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use sub tag to create a subscript format inside the html file
    <sub>This is your Subscript Format</sub>

</body>

</Subscript>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Superscript>

<body>

    // Note: use can use this Formatting elements inside a tag

    // use sup tag to create a superscript format inside the html file
    <sup>This is your Superscript Format</sup>

</body>


</Superscript>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Text Formatting Elements>
---------------------------------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Anchor Element>

<body>

    // use a tag to use the anchor element and load a html file
    <a href="Insert your html file">Name of your link</a>
    // example
    <a href="home.html">Home</a>

    // you can also use a tag to enter another link or website
    <a href="Insert Link">Name of your link</a>
    // example
    <a href="https://www.youtube.com/">Enter youtube</a>

</body>

<Anchor Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Href Attribute>
    
<body>

    // you can use href attribute to enter another link or html file
    <a href="https://www.youtube.com/">Enter Youtube</a>

</body>

</Href Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Target Attribute>

<body>

    // you can use target attribute to know which tab it will open
    
    // if you use target="_blank" attribute, the link will open at another tab
    <a href="https://www.youtube.com/" target="_blank">Enter Youtube</a>

    // if you use target="_self" attribute, the link will open at the current tab
    <a href="https://www.youtube.com/" target="_self">Enter Youtube</a>
    
    // if the target is empty or not called, the link will open at the same tab of the websie
    <a href="https://www.youtube.com/">Enter Youtube</a>

    // you can also use a tag inside another tag to customize the interface
    <p>Enter <a href="https://www.youtube.com/">youtube</a></p>

</body>

</Target Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Image Element>

<body>

    // use img tag to insert a image inside your website
    // the image you will insert have to be existed inside your computer
    // add the image inside the folder of your program
    <img src="picture.png" alt="image"/>

    // you can also use img tag to set the size of your image
    <img src="picture.png" width="200" height="200" alt="image"/>

</body>

</Image Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<image element attribute>

<body>

    // the src attricutes of the image indicates the File path to load the image
    <img src="picture.png"/>

    // the width attribute of the image indicates the width of the image
    <img src="picture.png" width="200"/>

    // the height attribute of the image indicates the height of the image
    <img src="picture.png" height="200"/>

    // the alt attribute of the image indicates what text will be shown if the image failed to load
    <img src="picture.png" alt="image"/>

    // Note: if you use only one height or width inside the img tag will indicate the aspect ratio of width or height as same

</body>

</image element attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<image element src attribute>

<body>

    // the src attribute can take a value of a file path
    // file path means that the image is existed inside the computer
    <img src="picture.png"/>

    // the src attribute can also take a value of the image link
    <image src="https://unsplash.com/photos/a-tall-building-with-a-sky-background-JF5SChGtuZQ"/>

    // you also use the image inside a folder
    // Note: the folder must be existing inside the folder of your program to prevent leak
    <img src="pictures/robotics8_8.jpg" alt="Robotics"/>

</body>

</image element src attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<image element width and height attribute>

<body>

    // the width and height attribute can be set in number form
    <img src="picture.png" width="200" height="200"/>

    // the width and height attribute can also be set in percentage form
    <img src="picture.png" width="50%" height="50%"/>

    // Note: if you use only one height or width inside the img tag will indicate the aspect ratio of the value used

</body>

</image element width and height attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<image element alt attribute>

<body>

    // use alt attribute to show a text when the image failed to load
    <img src="picture." alt="Error"/>

</body>

</image element alt attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------
<File Path>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Same folder>

<body>

    // the picture.png will open at the same folder of the program
    <img src="picture.png"/>

</body>

</File Path same folder>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Folder inside the folder of the program>

<body>

    // the picture.png will be called inside the images folder inside the program folder
    img src="images/picture.png"/>

</body>

</Folder inside the folder of the program>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Folder Images at the root of the current web>

<body>

    // same as the other one but the difference is this method is used when you have localhost
    <img src="/images/picture.png"/>

</body>

</Folder Images at the root of the current web>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<image one level up from the folder>

<body>

    // this method will find the picture.png one level up from the current folder and will continue until the picture.png is found
    <img src="../picture.png"/>

    // Note add another ../ method if the image you want to use is not currently there when backed
    // Note you also find the image path if the image you want to use is in another folder when backed
    <img src="../program1/picture.png"

</body>

</image one level up from the folder>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Absolute path>

<body>

    // the absolute path is used if you want to open a URL
    <img src="https://unsplash.com/photos/a-tall-building-with-a-sky-background-JF5SChGtuZQ"/>

    // Note: specific folder path is also called Absolute Path but it is not recommended and a bad practice for programming

</body>

</Absolute path>


---------------------------------------------------------------------------------------------------------------------------------------------------------

<File Path using a element>

<body>
    
    // you can also use file path for the a tag to find the specific file you want to load
    <a href="../program1/index.html">Index</a>

</body>

</File Path using a element>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</File Path>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Source Element>

<body>

    // use source tag to get the source file using src attributes and the type of the file using type attributes
    <source src="music.mp3" type="audio/mp3">

    <source src="music.ogg" type="audio/mp3">

    // Note source tag is used within <audio>,<video>, and <picture> elements

</body>

</Source Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Source Element Attribute>

<body>

    // src attributes indicates the file path of the file

    // type attributes indicates the MIME-type resource of the file

    // the src attributes is used to locate the file path
    // you can also use URL source
    <source src="music.mp3">
    <source src="music.ogg">

    // the type attributes specifies the MIME-type of the source
    <source src="vid.mp4" type="video/mp4">
    <source src="vid.ogg" type="video/ogg">

    // Note MIME-type helps in identifying file types so it can be handled accordingly

</body>

</Source Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Audio Element>

<body>

    // use audio element or tag to insert audio inside the website
    <audio controls>
        <source src="music.mp3" type="audio/mp3">
        <source src="music.ogg" type="audio.ogg">
        // this will appear if the browser does not support the audio tag
        Browser does not support the audio tag
    </audio>

    // alternative way to use the audio element or tag
    <audio src="music.mp3" controls>
        // this will appear if the browser does not support the audio tag
        Browser does not support the audio tag
    </audio>

</body>

</Audio Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Audio Element Attribute>

<body>

    // src attributes is used to indicates the file path

    // controls attributes is used to shows the play, pause, volume+, and volume-

    // autoplay attributes is used to play audio automatically when loaded
    // Note the autoplay attributes might not work on some browsers
    
    // muted attributes is used to mute the audio by default

    // loop attributes is used to make the audio replay infinite times

    // use src attributes to indicate the file path of the file
    <audio src="audio.mp3"/>

    // use controls attribute to show the play,pause,volume+, and volume-
    // you can also use url file paths
    <audio src="audio.mp3" controls/>

    // use autoplay to make the audio automatically play
    // Note if you insert autoplay attribute it will be set as default
    <audio src="audio.mp3" autoplay/>

    // use muted to make the audio muted
    // Note if you insert muted attribute it will be set as default
    <audio src="audio.mp3" muted/>

    // use loop to make the audio play infinitely
    // Note if you insert loop attribute it will be set as default
    <audio src="audio.mp3" loop/>

    // if the browser does not support autoplay you can still use autoplay as long as the video or audio is muted
    <audio src="audio.mp3" autoplay muted/>

    // Note some attributes does not need any value

</body>

</Audio Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Video Element>

<body>

    // Note refer to MIME-type to give a value in type attribute

    // use the video element or tag to insert a video 
    // the difference of video to the audio is that video can use a width and height to customize the video
    <video width="320" height="240" controls>
        // use source element of tag to insert a value of a video
        <source src="video.mp4" type="audio/mp4">
        <source src="video.ogg" type="audio/ogg">
        // this will show if the video tag is not supported in the browser
        Browser does not support the video tag
    </video>

    // alternative way to use the video tag
    <video src="video.mp4" width="320" height="240" controls>
        // this will show if the video tag is not supported in the browser
        Browser does not support the video tag   
    </video>

</body>

</Video Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Video Element Attribute>

<body>

    // src attributes is used to indicates the file path

    // controls attributes is used to shows the play, pause, volume+, and volume-

    // autoplay attributes is used to play audio automatically when loaded
    // Note the autoplay attributes might not work on some browsers
    
    // muted attributes is used to mute the audio by default

    // loop attributes is used to make the audio replay infinite times

    // width attribute is used to set the width of the video

    // height attribute is used to set the height of the video

    // Note if you only use one attribute between height and width the used attributes value will get the aspect ratio of the value of the unused attribute

    // use the src attribute to indicate the file path of the file
    // you can also use URL file path
    <video src="video.mp4"/>

    // use controls attribute to show the play,pause,volume+, and volume-
    // you can also use url file paths
    <video src="video.mp4" controls/>

    // use autoplay to make the video automatically play
    // Note if you insert autoplay attribute it will be set as default
    <video src="video.mp4" autoplay/>

    // use muted to make the video muted
    // Note if you insert muted attribute it will be set as default
    <video src="video.mp4" muted/>

    // use loop to make the video play infinitely
    // Note if you insert loop attribute it will be set as default
    <video src="video.mp4" loop/>

    // if the browser does not support autoplay you can still use autoplay as long as the video or audio is muted
    <video src="video.mp4" autoplay muted/>

    // use the width attribute to set the width of the video
    // Note if you only use one attribute between height and width the used attributes value will get the aspect ratio of the value of the unused attribute
    <video src="video.mp4" width="320"/>

    // use the height attribute to set the height of the video
    // Note if you only use one attribute between height and width the used attributes value will get the aspect ratio of the value of the unused attribute
    <video src="video.mp4" height="240"/>

</body>

</Video Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Video Element width and height attribute>

<body>

    // you can use numerical to set the size of the video using this attributes
    <video src="video.mp4" width="320" height="240"/>

    // you can also use percentage to set the size of the video using this attributes
    <video src="video.mp4" width="50%" height="50%"/>

    // Note if you only use one attribute between height and width the used attributes value will also be the value of the unused attribute

</body>

</Video Element width and height attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------
<List Type>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Unordered List>

<body>

    // use ul tag to use unordered list
    // the design of unordered list is bullet type list
    <ul>
        <li>
            // this is the li tag inside the unordered list
            // li tag gives a value inside the unordered list
        </li>
    </ul>

    // Note you can create a nested list 

</body>

</Unordered List>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Ordered List>

<body>

    // use ol tag to use ordered list
    // the design of ordered list is number type list
    <ol>
        <li>
            // this is the li tag inside the ordered list
            // li tag gives a value inside the ordered list
        </li>
    </ol>

    // Note you can create a nested list 

</body>

</Ordered List>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</List Type>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<List Item Element>

<body>

    // use li tag to insert a value inside the ordered list or unordered list
    <li>this is your list</li>

    // Note you can create a nested list 

</body>

</List Item Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<List Item Attribute>

<body>

    // value attributes is used to specify what value the count will start
    // value attributes usually used in ordered list

    // use ol tag to use ordered list
    <ol>
        // use value attribute to specify what number the count will start
        <li value="5">C</li>
        <li>C++</li>
        <li>C#</li>
        <li>java</li>
        <li>python</li>
    </ol>

    // Note you can create a nested list 

</body>

</List Item Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------
<Table Elements>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Table Element>

<body>

    // use table element or tag to create a table inside the html file
    // sample table
    <table>

        <tr>
            <th>this is your table1</th>
            <th>this is your table2</th>
        </tr>

        <tr>
            <td>this your table_data1</td>
            <td>this your table_data2</td>
        </tr>

    </table>

</body>

</Table Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Table Element Row>

<body>

    <table>
        // use tr element or tag to insert a row inside the table
        <tr>
            <th>This your table1</th>
        </tr>
        <tr>
            <td>this is your table_data1</td>
        </tr>

    </table>

</body>

</Table Element Row>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Table Element Heading>

<body>

    <table>

        <tr>
            // use th element or tag to insert a heading inside your table
            <th>this is your table1</th>
            <th>this is your table2</th>
        </tr>

        <tr>
            <td>this your table_data1</td>
            <td>this your table_data2</td>
        </tr>

    </table>

</body>

</Table Element Heading>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Table Element Data>

<body>

    <table>

        <tr>
            <th>this is your table1</th>
            <th>this is your table2</th>
        </tr>

        <tr>
            // use td element or tag to insert a data inside your table
            <td>this your table_data1</td>
            <td>this your table_data2</td>
        </tr>

    </table>

</body>

</Table Element Data>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Table Element Heading & Data Attributes>

<body>

    <table>

        <tr>
            // inside the th element, use colspan or rowspan to merge to another column or row in its surrounding
            // by giving value 2, the table will merge table depending on the value given
            <th colspan="2">this is your table1</th>
            <th rowspan="2">this is your table2</th>
        </tr>

        <tr>
            // inside the th element, use colspan or rowspan to merge to another column or row in its surrounding
            // by giving value 3, the table will merge table depending on the value given
            <td colspan="3">this your table_data1</td>
            <td rowspan="3">this your table_data2</td>
        </tr>

    </table>

</body>

</Table Element Heading & Data Attributes>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Caption Element>

<body>

    <table>
        // caption tag are default centered on top of the table
        <caption>Caption</caption>
        <tr>
            <th>this is your table1</th>
            <th>this is your table2</th>
        </tr>

        <tr>
            <td>this your table_data1</td>
            <td>this your table_data2</td>
        </tr>

    </table>

</body>

</Caption Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Table Elements>
---------------------------------------------------------------------------------------------------------------------------------------------------------
<Form Element>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Form Element>

<body>

    // use form element or tag to create a form inside the html file
    // this is a sample form
    // action attribute contains the value of the php file
    // targer attribute is where the form tag will appear
    <form action="action_page.php" target="_blank">
        <input type="email"/><br>
        <input type="password"/><br>
        <input type="submit"/>
    </form>

</body>

</Form Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Form Element Attribute>

<body>

    // action attribute specifies the action to perform after submitting the form
    // method attribute specifies the type of method that the form will use
    // method attribute have 2 values GET or POST  
    // target attribute specifies where the result will display after submitting the form
    
    // use action attribute to specify the action to perform after submitting the form
    <form action="action_page.php"></form>

    // use method attribute to specify what method the form will use
    <form method="POST"></form>

    // use target attribute to specify where the result will display
    <form target="_blank"></form>

    // Note the form element attributes will be relevant if you use php

</body>

</Form Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Form Element>
---------------------------------------------------------------------------------------------------------------------------------------------------------
<Input Element>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Text>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="text"/>

    // the display will be normal plain text input

</body>

</Input Element Text>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Password>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="password"/>

    // the display will be password type input

</body>

</Input Element Password>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Radio>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="radio"/>

    // the display will be a radio type input
    // Note you can only select one option when using radio button

</body>

</Input Element Radio>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element CheckBox>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="checkbox"/>

    // the display will be a checbox type input
    // Note you can select multiple option when using checkbox

</body>

</Input Element CheckBox>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Range>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="range"/>

    // the display will be a draggable rate type input

</body>

</Input Element Range>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Number>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="number"/>

    // when using number value you can only insert a number value


</body>

</Input Element Number>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Date>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="date"/>

    // the display will be a date type input

</body>

</Input Element Date>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element File>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="file"/>

    // when using file value you can choose file from your computer input

</body>

</Input Element File>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Button>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="button"/>

    // the display will be a button type input

</body>

</Input Element Button>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Color>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="color"/>

    // the design will be a color picker type input

</body>

</Input Element Color>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element DateTime-Local>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="datetime-local"/>

    // the design will be a complete date information with m/d/y h/r/s type input

</body>

</Input Element DateTime-Local>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Email>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="email"/>

    // the design will be an email type input
    // at the html it will look like a normal text type input 
    // if you hover from it will hover a missing @ if you did not isert an @

</body>

</Input Element Email>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Hidden>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="hidden"/>

    // the design will be hidden frome user
    // hidden value typically used in java script

</body>

</Input Element Hidden>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Image>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="image"/>

    // the design will be an image with no value

</body>

</Input Element Image>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Month>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="month"/>

    // the design will be a month type input

</body>

</Input Element Month>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Reset>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="reset"/>

    // the design will be a reset button

</body>

</Input Element Reset>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Search>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="search"/>

    // the design will be a search type input

</body>

</Input Element Search>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Telephone>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="tel"/>

    // the design will be a normal text type input but gives error when giving text

</body>

</Input Element Telephone>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Time>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="time"/>

    // the design will be a h/r/s type input

</body>

</Input Element Time>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element URL>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="url"/>

    // the design will be a normal text type input but when hover it will hover a "enter a URL"

</body>

</Input Element URL>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Week>

<body>

    // use the input type attribute to specify what type of input you are using
    <input type="week"/>

    // the design will be a week type input

</body>

</Input Element Week>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Input Element>
---------------------------------------------------------------------------------------------------------------------------------------------------------
<Input Element Attributes>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute Type>

<body>

    // use type attribute to specify what type of input is this
    <input type="text"/>

</body>

</Input Element Attribute Type>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute Name>

<body>

    // use name attribute to specify what is the name of the input
    // the value given in name is usally taken from the name attribute in label
    <input name="fname"/>

</body>

</Input Element Attribute Name>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute Value>

<body>

    // use value attribute to specify what is the value of the input
    // the value attribute is usually used for radio type input
    // use name attribute to specify what radio group it belongs
    <input type="radio" value="male" name="gender"/>

    // you can also use value attributes to give a default value inside the textfield
    <input type="text" value="Program"/>

</body>

</Input Element Attribute Value>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute Required>

<body>

    // use required attribute to let the user fill that up
    // if the input is not filled the submit will not be processed
    <input type="text" required/>

</body>

</Input Element Attribute Required>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute Disabled>

<body>

    // use disbled attributes to avoid user filling up the disabled input input
    <input type="text" disabled/>

</body>

</Input Element Attribute Disabled>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Attribute ReadOnly>

<body>

    // use readonly attributes to let the user not to edit the text
    // input that have used readonly attributes usually have a fix text inside the input
    <input type="text" readonly/>

</body>

</Input Element Attribute ReadOnly>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Input Element Attributes>
---------------------------------------------------------------------------------------------------------------------------------------------------------
<Input Element Type Attributes>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Type Attributes Placeholder>

<body>

    // use placeholder attribute to give a hint inside the textfield
    <input type="text" placeholder="this is your hint"/>

</body>

</Input Element Type Attributes Placeholder>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Type Attributes Minlength>

<body>

    // use minlength attributes to give a minimum input of the user
    // minlength usually used in password to give 8 digit password or more
    // by giving an 8 value for the minlength, the user must input atleast 8 or more text to validate
    <input type="text" minlength="8"/>

</body>

</Input Element Type Attributes Minlength>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Type Attributes Maxlength>

<body>

    // use maxlength attribute to specify the max value of the input to prevent user to place more value
    <input type="text" maxlength="32"/>

</body>

</Input Element Type Attributes Maxlength>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Type Attributes Size>

<body>

    // use size attribute to customize the size of the input field
    <input type="text" size="8"/>

</body>

</Input Element Type Attributes Size>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Element Type Attributes Step>

<body>

    // use step attribute to specify what count does the number attributes will do
    // if step = 3 the count will do +3 per click
    // step attribute can only be used in type attribute number value
    <input type="number" step="3"/>

</body>

<Input Element Type Attributes Step>

---------------------------------------------------------------------------------------------------------------------------------------------------------
</Input Element Type Attributes>
---------------------------------------------------------------------------------------------------------------------------------------------------------
<Element Date Attribute>
---------------------------------------------------------------------------------------------------------------------------------------------------------

<Element Date Attribute Value>

<body>

    // Note each date elements have different formats when using value

    // date element's format is year-month-day
    

    <input type="date" value="2020-05-06"/>

    // datetime-local element's format is year-month-dayThour:minute
    // Note use 24 hour format to specify the time
    // 13:00 is 1:00 PM

    <input type="datetime-local" value="2020-05-06T13:00"/>

    // month element's format is year-month

    <input type="month" value="2020-12"/>

    // week element's format is year-Wweek

    <input type="week" value="2020-W36"/>

    // time elements' format is hour:minute

    <input type="time" value="13:00"/>

    // Note if you use one digit in month or day make sure to add 0 digit before the value

</body>

</Element Date Attribute Value>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Element Date Attribute Min>

<body>

    // Note each date elements have different formats when using value

    // date element's format is year-month-day
    

    <input type="date" min="2020-05-06"/>

    // datetime-local element's format is year-month-dayThour:minute
    // Note use 24 hour format to specify the time
    // 13:00 is 1:00 PM

    <input type="datetime-local" min="2020-05-06T13:00"/>

    // month element's format is year-month

    <input type="month" min="2020-12"/>

    // week element's format is year-Wweek

    <input type="week" min="2020-W36"/>

    // time elements' format is hour:minute

    <input type="time" min="13:00"/>

    // Note if you use one digit in month or day make sure to add 0 digit before the value

</body>

</Element Date Attribute Min>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Element Date Attribute Max>

<body>

    // Note each date elements have different formats when using value

    // date element's format is year-month-day
    

    <input type="date" max="2020-05-06"/>

    // datetime-local element's format is year-month-dayThour:minute
    // Note use 24 hour format to specify the time
    // 13:00 is 1:00 PM

    <input type="datetime-local" max="2020-05-06T13:00"/>

    // month element's format is year-month

    <input type="month" max="2020-12"/>

    // week element's format is year-Wweek

    <input type="week" max="2020-W36"/>

    // time elements' format is hour:minute

    <input type="time" max="13:00"/>

    // Note if you use one digit in month or day make sure to add 0 digit before the value

</body>

</Element Date Attribute Max>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Attribute File Attribute>

<body>

    // accept attributes specifiy the files accepted
    // multiple attributes specify if multiple files are needed to accept

    // Note refer to MIME-types to give a value in accept and multiple attributes

    // use accept attributes to specify what value does the file will accept
    // Note the image/png is taken in MIME-type
    <input type="file" accept="image/png"/>

    // you can also use accept attributes to give a multiple value

    <input type="file" accept="image/png,image/svg+xml"/>

    // use multiple attributes to specify if the user needs to insert 1 or more file in the web

</body>

</Input Attribute File Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Input Attribute CheckBox.Radiobox Attribute>

<body>

    // checked attributes specify a default checked item in radiobox and checkbox

    // use checked attribute to set the item as a default checked when the website is running
    <input type="checkbox" id="apple" checked/>
    <label for="apple">apple</label>

    // you can also use checked attribute for radio to make an item as default
    <input type="radio" id="male" checked/>
    <label for="gender">Male</label>
    <input type="radio" name="gender" id="female">
    <label for="gender">Female</label>

</body>

</Input Attribute CheckBox,Radiobox Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Textarea Element>

<body>

    // use textarea value to use the textarea

    <input type="textarea"/>

</body>

</Textarea Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Textarea Element Attribute>

<body>

    // use rows attribute to specify the row of the textarea
    // use cols attribute to specify the col of the textarea

    // use the cols attribute to specify the cols of the textarea
    <input type="textarea" cols="50"/>

    // use the rows attribute to specify the rows of the textarea
    <input type="textarea" rows="4"

</body>

</Textarea Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Select Element>

<body>

    // select tags indicates a a dropdown list

    // use select attributes to create a dropdown list 
    <select name="course">
        <option value="bsit">BSIT</option>
        <option value="bsa">BSA</option>
    </select>

</body>

<Select Element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<Select Element Attribute>

<body>

    // multiple attribute specifies if the user can select multiple items in the list
    // size attribute specifies the number of options visible on the dropdown
    // name attribute specifies the name of the select element
    // required attribute specifies that the option is required for the user to answer 
    // disabled attribute specifies that the option is disabled for the user to answer
    // form attributes specifies the form it belongs to using the the form's id

</body>

</Select Element Attribute>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<optiongroup element>

<body>

    <select name="course">
        // use optgroup tag to specify what group does the options belong
        <optgroup label="bachelor">
            <option value="BSIT">BSIT</option>
            <option value="BSA">BSA</option>
        </optgroup>
    </select>
    
    // Note you can create many optgroup tag as many as you want

</body> 

<optiongroup element>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<HTML Entity(special characters)>

<body>

    // sample syntax for entities or special characters

    // special character    blank or space between elements or tag
    // Description Non-breaking space
    // Entity name &nbsp;
    &nbsp;
    // Entity number &#160;
    &#160;
    // Entity hex &#xa0;
    &#xa0;

    // use this to use the special characters

    // Note Not all entities or special characters have an entity

    // refer to the link to get the full entity list 
    https://www.freeformatter.com/html-entities.html

    // use this link to get your desired etities or special characters


</body>

</HTML Entity(special characters)>

---------------------------------------------------------------------------------------------------------------------------------------------------------

<HTML Emojis>

<body>

    // sample sytax for emojis

    // Description Tears of joy
    // Entity number &#128514;
    &#128514;
    // Entity hex &#x1f602;
    &#x1f602;

    // use this to use the special character(Emojis)

    // Note special characters(emojis) does not have a value in Entity name
    // use entity number or hex to use the special characters

    // refer to the link to get the full entity lists for the emojis
    https://www.w3schools.com/html/html_emojis.asp

    // use this link to get your desired entities or special character(Emojis)

    // Note make sure you insert this syntax to fully use this special characters
    <meta charset="UTF-8"/>
    // make sure you have this in your head tag inside the html file to use this special characters(emojis)

</body>

</HTML Emojis>

---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------


-->