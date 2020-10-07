import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public products: Product[];

  //constructor(http: HttpClient, @Inject('API_URL') apiUrl: string) {
  //  http.get<WeatherForecast[]>(apiUrl + 'SampleData/WeatherForecasts').subscribe(result => {
  //    this.forecasts = result;
  //  }, error => console.error(error));
  //}
  constructor(http: HttpClient, @Inject('API_URL') apiUrl: string) {
    http.get<Product[]>(apiUrl + 'product').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }

}

interface Product {
  productId: number;
  name: string;
  price: any;
  stock: number;
  image: string;
}
