var toolsViewModel = {
    migrationStatus: ko.observable({
        SubjectsInDatabase: 0,
        SubjectsInFileSystem: 0
    }),

    systemProgress: ko.observable('Ready'),

    updateMigrationStatus: function () {
        $.get('/api/Migrate').done(function (data) {
            toolsViewModel.migrationStatus(data);
        });
    },

    runMigration: function () {
        toolsViewModel.systemProgress('Migration started.');
        $.post('/api/Migrate').done(function (data) {
            toolsViewModel.systemProgress('Migration complete. ' + data.SubjectsMigrated + ' subject(s) migrated.')
        });

    }
};

$(document).ready(function () {
    ko.applyBindings(toolsViewModel);
});
