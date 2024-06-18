import http from 'k6/http';

export const options = {
    vus: 10,
    duration: '30s',
  };
  export default function () {
    http.get('https://kryseshoppublicapi.azurewebsites.net/calculatePi?operations=1000000000');
  }