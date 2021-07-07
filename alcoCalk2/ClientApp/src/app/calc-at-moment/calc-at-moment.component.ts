import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormBuilder } from '@angular/forms';
import { AfterViewInit, ElementRef, OnDestroy, ViewChild } from '@angular/core';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './calc-at-moment.component.html',
  styleUrls: ['./bootstrap.min.css']
})
export class CalcAtMomentComponent {

  public stringResult: string = null;
  private http: HttpClient;
  private baseUrl: string;
  checkoutForm = this.formBuilder.group({
    name: '', weight: '', alcoVolume: '',
    age: '',
    alcoGradus: ''
  });

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private formBuilder: FormBuilder) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  onSubmit(): void {
    this.getString(
      this.checkoutForm.get("name").value,
      this.checkoutForm.get("age").value,
      this.checkoutForm.get("weight").value,
      this.checkoutForm.get("alcoGradus").value,
      this.checkoutForm.get("alcoVolume").value);
    console.warn('Your order has been submitted', this.checkoutForm.get("name").value);
  }


  public getString(name, age, weight, alcoGradus, alcoVolume) {
    let body = 'name=' + name;
    body = body + '&age=' + age;
    body = body + '&weight=' + weight;
    body = body + '&alcoGradus=' + alcoGradus;
    body = body + '&alcoVolume=' + alcoVolume;
    var headers = new HttpHeaders();
    headers.append('Content-Type', 'application/x-www-form-urlencoded');
    this.http.post<CalcResponce>(this.baseUrl + 'AlcoCalculate?' + body, { headers: headers}).subscribe(result => {
      this.stringResult = result.responceText;
    }, error => console.error(error));
  }

}

interface CalcResponce {
  responceText: string;
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}


