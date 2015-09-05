$(document).ready(function () {
    console.log('page ready.')

    $('#migrationStatusButton').click(function (e) {
        e.preventDefault();
        $.get({
            url: 'api/Migrate'
        }).done(function(data) {
            console.log(data);
        });
    });
});
