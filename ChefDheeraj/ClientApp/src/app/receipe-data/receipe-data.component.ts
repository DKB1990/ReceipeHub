import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-receipe-data',
  templateUrl: './receipe-data.component.html'
})
export class ReceipeDataComponent {
  public receipes: Receipe[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Receipe[]>(baseUrl + 'api/Receipe/').subscribe(result => {
      this.receipes = result;
    }, error => console.error(error));
  }
}

interface EntityBase {
  id: string
}

interface Receipe extends EntityBase {
  title: string
  steps: Step[]
  images: Image[]
  ingredients: Ingredient[]
  level: string
  createdDate : string
}

interface Step extends EntityBase {
  receipeId: string
  description: string
}
interface Image extends EntityBase {
  receipeId: string
  ImagePath: string
}
interface Ingredient extends EntityBase {
  receipeId: string
  Name: string
}
