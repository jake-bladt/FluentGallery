var toolsViewModel = {
    migrationStatus: {
        SubjectsInDatabase: -1,
        SubjectsInFileSystem: -1
    }
};

$(document).ready(function () {
    ko.applyBindings(toolsViewModel);

    $('#migrationStatusButton').click(function (e) {
        e.preventDefault();
        $.get('/api/Migrate'
          ).done(function(data) {
            console.log(data);
        });
    });
});
