window.navClick = {
    addOutsideClickListener: function (dotNetHelper) {
        function handleClick(event) {
            const navWrapper = document.getElementById("navWrapper");
            const burger = document.querySelector(".burger-button");
            const menu = document.querySelector(".burger-menu");

            // if the click is outside navWrapper, close menu
            if (
                !navWrapper.contains(event.target) &&
                !burger.contains(event.target) &&
                !menu.contains(event.target)
            ) {
                dotNetHelper.invokeMethodAsync("CloseMenu");
            }
        }

        document.addEventListener("click", handleClick);
        // store the handler so we can remove it later
        window.navClick._handler = handleClick;
    },

    removeOutsideClickListener: function () {
        if (window.navClick._handler) {
            document.removeEventListener("click", window.navClick._handler);
            window.navClick._handler = null;
        }
    }
};
