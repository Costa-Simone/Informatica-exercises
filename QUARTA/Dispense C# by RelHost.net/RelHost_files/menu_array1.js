// The following line is critical for menu operation, and must appear only once.
menunum=0;menus=new Array();_d=document;function addmenu(){menunum++;menus[menunum]=menu;}function dumpmenus(){mt="<script language=javascript>";for(a=1;a<menus.length;a++){mt+=" menu"+a+"=menus["+a+"];"}mt+="<\/script>";_d.write(mt)}
//Please leave the above line intact

effect = "Fade(duration=0.1);Alpha(style=0,opacity=100);Shadow(color='#0000aa', Direction=135, Strength=3)"

timegap=500		// The time delay for menus to remain visible
followspeed=5		// Follow Scrolling speed
followrate=40		// Follow Scrolling Rate
suboffset_top=10;	// Sub menu offset Top position 
suboffset_left=10;	// Sub menu offset Left position

style1=[		// style1 is an array of properties. You can have as many property arrays as you need. This means that menus can have their own style.
"white",		// Mouse Off Font Color
"#0000aa",		// Mouse Off Background Color
"red",		    // Mouse On Font Color
"d1d1d1",	    // Mouse On Background Color
"#0000aa",		// Menu Border Color 
11,			// Font Size in pixels
"normal",		// Font Style (italic or normal)
"bold",			// Font Weight (bold or normal)
"Verdana,Arial,Helvetica,sans-serif",	// Font Name
3,			// Menu Item Padding
,			// Sub Menu Image (Leave this blank if not needed)
"#0000aa",		// 3D Border & Separator bar
"#0000aa",			// 3D High Color
"#0000aa",			// 3D Low Color
,			// Current Page Item Font Color (leave this blank to disable)
,			// Current Page Item Background Color (leave this blank to disable)
"morenew.gif",	// Top Bar image (Leave this blank to disable)
,			// Menu Header Font Color (Leave blank if headers are not needed)
,			// Menu Header Background Color (Leave blank if headers are not needed)
]

addmenu(menu=[	// This is the array that contains your menu properties and details
"mainmenu",	// Menu Name - This is needed in order for the menu to be called
60,		// Menu Top - The Top position of the menu in pixels
3,		// Menu Left - The Left position of the menu in pixels
,		// Menu Width - Menus width in pixels
0,		// Menu Border Width 
"left",	// Screen Position - here you can use "center;left;right;middle;top;bottom" or a combination of "center:middle"
style1,		// Properties Array - this is set higher up, as above
1,		// Always Visible - allows the menu item to be visible at all time (1=on/0=off)
"left",		// Alignment - sets the menu elements text alignment, values valid here are: left, right or center
effect,		// Filter - Text variable for setting transitional effects on menu activation - see above for more info
,		// Follow Scrolling - Tells the menu item to follow the user down the screen (visible at all times) (1=on/0=off)
1, 		// Horizontal Menu - Tells the menu to become horizontal instead of top to bottom style (1=on/0=off)
,		// Keep Alive - Keeps the menu visible until the user moves over another menu or clicks elsewhere on the page (1=on/0=off)
,		// Position of TOP sub image left:center:right
,		// ..Now Obsolete..
,		// Right To Left - Used in Hebrew for example. (1=on/0=off)
,		// Open the Menus OnClick - leave blank for OnMouseover (1=on/0=off)
,		// ID of the div you want to hide on MouseOver (useful for hiding form elements)
,		// Reserved for future use
,		// Reserved for future use
,		// Reserved for future use
// "Description Text", "URL", "Alternate URL", "Status", "Separator Bar"
,"Relhost&nbsp;&nbsp;&nbsp;&nbsp;","show-menu=home",,"RelHost Site",1
,"Contatti&nbsp;&nbsp;&nbsp;&nbsp;","show-menu=canali",,"Contatti",1
,"Programmazione&nbsp;&nbsp;&nbsp;&nbsp;","show-menu=programmi",,"Programmi",1
,"Hobbies&nbsp;&nbsp;&nbsp;&nbsp;","show-menu=hobbies",,"Hobbies",1
,"Varie&nbsp;&nbsp;&nbsp;&nbsp;","show-menu=immagini",,"Immagini;",1
])

addmenu(menu=["home",
,,140,1,"",style1,,"left",effect,,,,,,,,,,,,
,"Home","index.htm",,,1
,"Mappa","todo.htm",,,1
,"About","todo.htm",,,1
])

addmenu(menu=["canali",
,,170,1,"",style1,,"left",effect,,,,,,,,,,,,
,"Relhost","mailto:relhost@relhost.net",,,1
,"Feedback","mailto:feedback@relhost.net",,,1
,"Blog","http://x-rel.spaces.live.com/default.aspx",,,1
])

addmenu(menu=["programmi",
,,150,1,"",style1,,"left",effect,,,,,,,,,,,,
,"Falcon","flc001.html",,"Falcon",1
,"Asp.Net","todo.htm",,"Asp:net",1
,"XAML & SilverLight","todo.htm",,"XAML",1
,"C#","csharp.html",,"C#",1
,"D Language","todo.htm",,"D Language",1
,"Cobra","todo.htm",,"Cobra",1
])

addmenu(menu=["hobbies",
,,140,1,"",style1,,"left",effect,,,,,,,,,,,,
,"Scacchi","todo.htm",,,1
,"Trekking","todo.htm",,,1
,"Sport","sport.htm",,,1
])

addmenu(menu=["immagini",
,,172,1,"",style1,,"left",effect,,,,,,,,,,,,
,"Links interessanti","links.htm",,,1
])


dumpmenus()