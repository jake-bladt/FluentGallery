var toolsViewModel = {
    migrationStatus: ko.observable({
        SubjectsInDatabase: 0,
        SubjectsInFileSystem: 0
    }),

    updateMigrationStatus: function () {
        $.get('/api/Migrate').done(function (data) {
            toolsViewModel.migrationStatus(data);
        });
    }
};

$(document).ready(function () {
    ko.applyBindings(toolsViewModel);
});
