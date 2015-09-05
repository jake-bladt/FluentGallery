$(document).ready(function () {
    console.log('page ready.')

    $('#migrationStatusButton').click(function () {
        $.get({
            url: 'api/Migrate'
        }).done(function(data) {
            console.log(data);
        });
    });
});
