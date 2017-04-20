import {inject} from "aurelia-framework";
import {MovieData} from "./movieData";

@inject(MovieData)
export class List {
    constructor(movieData) {
        this.movieData = movieData;
    }

    // injects HttpClient into constructor
    //static inject() { return [HttpClient]; }

    activate() {
        return this.movieData.getAll().then(
            movies => this.movies = movies
        );
    }
}