window.facebookEmbed = (() => {
    let sdkLoadPromise;

    function ensureFbRoot() {
        if (document.getElementById("fb-root")) {
            return;
        }

        const root = document.createElement("div");
        root.id = "fb-root";
        document.body.prepend(root);
    }

    function waitForFacebookSdk(resolve, reject) {
        let attempts = 0;
        const maxAttempts = 50;

        const checkForSdk = () => {
            if (window.FB && window.FB.XFBML) {
                resolve(window.FB);
                return;
            }

            attempts += 1;

            if (attempts >= maxAttempts) {
                reject(new Error("Facebook SDK did not finish loading."));
                return;
            }

            window.setTimeout(checkForSdk, 100);
        };

        checkForSdk();
    }

    function loadSdk() {
        if (window.FB && window.FB.XFBML) {
            return Promise.resolve(window.FB);
        }

        if (sdkLoadPromise) {
            return sdkLoadPromise;
        }

        sdkLoadPromise = new Promise((resolve, reject) => {
            ensureFbRoot();

            const existingScript = document.querySelector("script[data-facebook-sdk='true']");
            if (existingScript) {
                waitForFacebookSdk(resolve, reject);
                return;
            }

            const script = document.createElement("script");
            script.async = true;
            script.defer = true;
            script.crossOrigin = "anonymous";
            script.dataset.facebookSdk = "true";
            script.src = "https://connect.facebook.net/da_DK/sdk.js#xfbml=1&version=v23.0";
            script.onload = () => waitForFacebookSdk(resolve, reject);
            script.onerror = () => reject(new Error("Failed to load the Facebook SDK."));

            document.body.appendChild(script);
        });

        return sdkLoadPromise;
    }

    async function parse(element) {
        const fb = await loadSdk();

        if (!element) {
            fb.XFBML.parse();
            return;
        }

        fb.XFBML.parse(element);
    }

    return { parse };
})();
