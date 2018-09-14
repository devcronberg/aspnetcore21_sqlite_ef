(function () {

    $().ready(function () {

        clk();

        // henter id=1
        $.getJSON("/home/opdaterperson/1").done(function (d) {
            $("#navn").val(d.navn);
        }).fail(function (e) {
            $("#fejl").html(e.responseText);
        });

        $("#btn").click(function () {
            $.post("/home/opdaterperson", { personId: 1, navn: $("#navn").val() }).done(function () {
                location.reload();
            }).fail(function (e) {
                $("#fejl").html(e.responseText);
            });
        });

        setInterval(function () {
            clk();
        }, 1000);

        function clk() {
            $("#time").html(new Date().toLocaleTimeString("da-DK"));
        }
    });
})()