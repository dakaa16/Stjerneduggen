window.navScroll = (() => {
    let handler = null;

    return {
        init(dotNetHelper) {
            if (handler !== null) {
                window.removeEventListener("scroll", handler);
                handler = null;
            }

            handler = () => {
                dotNetHelper.invokeMethodAsync("OnWindowScroll", window.scrollY);
            };
            window.addEventListener("scroll", handler);
        },
        cleanup() {
            if (handler !== null) {
                window.removeEventListener("scroll", handler);
                handler = null;
            }
        }
    };
})();

window.setNavHeightVar = (value) => {
    document.documentElement.style.setProperty("--nav-height", value);
};
