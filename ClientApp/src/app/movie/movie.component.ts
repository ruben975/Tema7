import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-movie-component',
  templateUrl: './movie.component.html'
})
export class MovieComponent {
  public movies: Movie[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Movie[]>(baseUrl + 'api/movies1').subscribe(result => {
      this.movies = result;
    }, error => console.error(error));
  }
}

export class Movie {
  id: string;
  name: string;
  genre: string;
}
