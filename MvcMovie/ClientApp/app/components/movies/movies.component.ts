import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'movies',
    templateUrl: './movies.component.html',
    styleUrls: ['./movies.component.css']
})
export class MoviesComponent {
    public movies: Movies[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Movies').subscribe(result => {
            this.movies = result.json() as Movies[];
        }, error => console.error(error));
    }
}


interface Movies {
    id: number;
    title: string;
    releaseDate: number;
	genre: string;
	rating: string;
    price: number;
  
}
