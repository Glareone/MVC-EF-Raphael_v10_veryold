window.onload = function () {
    var paper = new Raphael(document.getElementById('canvas_container'), 500, 500);
    var tetronimo = paper.path("M 250 250 l 0 -50 l -50 0 l 0 -50 l -50 0 l 0 50 l -50 0 l 0 50 z");
    tetronimo.attr(
         {
             gradient: '90-#526c7a-#64a0c1',
             stroke: '#3b4449',
             'stroke-width': 10,
             'stroke-linejoin': 'round',
             rotation: -90
         }
     );

    tetronimo.animate({"transform": "r 360", 'stroke-width': 1}, 2000, 'bounce', function() {
        /* callback after original animation finishes */
        this.animate({
            "transform": "r -90",
            "stroke": "#3b4449",
            'stroke-width': "10"
        }, 1000);
    });

    var text = paper.text(250, 250, 'Bye Bye! ')
    text.attr(
        {
            opacity: 0,
            "font-size": 16,
            fill: '#fff'
        }).toBack();

    tetronimo.animate({
        path: "M 250 250 l 0 -50 l -50 0 l 0 -50 l -100 0 l 0 50 l 50 0 l 0 50 z"
    }, 5000, 'elastic');

    tetronimo.node.onmouseover = function () {
        this.style.cursor = 'pointer';
    }

    tetronimo.node.onclick = function () {

        text.animate({opacity: 1}, 2000);
        tetronimo.animate({opacity: 0}, 2000, function() {
            this.remove();
        });
    }
}
