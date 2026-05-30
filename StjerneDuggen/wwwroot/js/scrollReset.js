window.scrollReset = (() => {
    function scrollToTop() {
        window.scrollTo({ top: 0, left: 0, behavior: "instant" });
        document.documentElement.scrollTop = 0;
        document.body.scrollTop = 0;
    }

    return {
        resetToTop() {
            scrollToTop();

            requestAnimationFrame(() => {
                scrollToTop();

                requestAnimationFrame(scrollToTop);
            });
        }
    };
})();
