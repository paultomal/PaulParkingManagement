var app = angular.module('registrationApp', []);

app.controller('RegistrationController', function($scope) {
  $scope.user = {};
  $scope.registrationSuccess = false;
  $scope.registrationError = '';

  $scope.register = function() {
    // Perform registration logic here
    // You can use $http service to make API requests to your backend
    // For simplicity, let's assume the registration is successful
    $scope.registrationSuccess = true;
    $scope.registrationError = '';
    $scope.user = {};
  };
});
