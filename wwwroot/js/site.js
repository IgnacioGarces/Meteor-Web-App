//site.js
window.enableNavScroll = () => {
    document.querySelectorAll('#mainNavbar a.nav-link').forEach(link => {
        link.addEventListener('click', function (e) {
            const isHome = window.location.pathname === "/";

            if (this.hash && isHome) {
                e.preventDefault();

                const el = document.querySelector(this.hash);
                const container = document.querySelector('.snap-container');

                if (el && container) {
                    container.scrollTo({
                        top: el.offsetTop,
                        behavior: 'smooth'
                    });
                }
            }
        });
    });
};

window.initActiveSections = () => {
    const container = document.querySelector('.snap-container');
    const sections = document.querySelectorAll('section[id]');
    const navLinks = document.querySelectorAll('#mainNavbar .nav-link');

    if (!container) return;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                const id = entry.target.id;

                navLinks.forEach(link => {
                    link.classList.remove('active');

                    if (link.getAttribute('href') === '#' + id) {
                        link.classList.add('active');
                    }
                });
            }
        });
    }, {
        root: container,
        threshold: 0.6
    });

    sections.forEach(section => observer.observe(section));
};

window.scrollToHash = () => {
    if (location.hash) {
        const el = document.querySelector(location.hash);
        const container = document.querySelector('.snap-container');

        if (el && container) {
            container.scrollTo({
                top: el.offsetTop,
                behavior: 'smooth'
            });
        }
    }
};