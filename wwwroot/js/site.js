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
            el.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });

            
            setTimeout(() => {
                container.style.scrollSnapType = 'none';

                container.offsetHeight;

                container.style.scrollSnapType = 'y mandatory';
            }, 400);
        }
    }
};


//GAME

window.openFullscreen = () => {
    // Intentamos poner en fullscreen el CONTENEDOR, no solo el iframe
    // para que tu botón y el aviso de rotación sigan funcionando dentro.
    const elem = document.querySelector('.game-container');
    
    if (elem.requestFullscreen) {
        elem.requestFullscreen();
    } else if (elem.webkitRequestFullscreen) {
        elem.webkitRequestFullscreen(); // Safari / iOS
    } else if (elem.mozRequestFullScreen) {
        elem.mozRequestFullScreen(); // Firefox
    }
};