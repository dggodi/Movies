export function configure(aurelia) {

    aurelia.use
        .standardConfiguration()
        .developmentLogging();

    // determines what module to load
    aurelia.start().then(a => a.setRoot());

};