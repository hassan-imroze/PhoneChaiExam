module App {
    export class PhoneQueryController {
        Phones: Phone[];

        private phoneService: PhoneService;
        static $inject = ["PhoneService"];
        constructor($phoneService: PhoneService)
        {
            this.phoneService = $phoneService;
            this.Phones = [];
            this.Get();
        }

        Get() {
            var self = this;

            self.phoneService.Get()
                .then(successCallback, errorCallback);

            var successCallback = result => {
                self.Phones = result.data as Phone[];
            };
            var errorCallback = error => {
                console.log(error);
            };           
        }
    }

    angular.module("app").controller("PhoneQueryController", PhoneQueryController);

}