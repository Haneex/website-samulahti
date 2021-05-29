OnLoad(function()
{
    // Find all elements that have a href of #topmenu
    var menuExpanders = document.querySelectorAll("[href='#topmenu']");

    ForEach(menuExpanders, function(item)
    {
        // Listen on the click event
        item.addEventListener("click", function(e)
        {
            // Cancel navigation
            e.preventDefault();

            // Add the desired class to this item
            var topMenus = document.querySelectorAll("[data-topmenu-class]");

            // For each menu..
            ForEach(topMenus, function(menu)
            {  
                // Add desired class
                menu.classList.toggle("expanded");              
            });

            // Find any elements with a data-scrolldown-class attribute
            // and adds that class to them when we scroll from the top of the the page
            var hamburgerMenus = document.querySelectorAll("[hamburger-menu-active]");

            // For each element...
            ForEach(hamburgerMenus, function(menu)
            {
                // Add the desired class
                menu.classList.toggle("is-active");
            });     

        });
    });    
});