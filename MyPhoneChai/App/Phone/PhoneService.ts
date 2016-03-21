module App {
    export class PhoneService {
        private httpService: angular.IHttpService;
        private qService: angular.IQService;

        static $inject: string[] = ["$http", "$q"];
        constructor(private $http: ng.IHttpService, private $qService: ng.IQService) {
            this.httpService = $http;
            this.qService = $qService;
        }

        Get() {
            var self = this;
            var deffered = this.qService.defer();

            self.httpService.get("/api/phonequery").then(successCall, errorCall);

            var successCall = result => {
                console.log(result);
                return deffered.resolve(result);
            }

            var errorCall = error => {
                console.log(error);
                return deffered.reject(error);
            }

            return deffered.promise;
        }
    }

    angular.module("app").service("PhoneService", PhoneService);
}