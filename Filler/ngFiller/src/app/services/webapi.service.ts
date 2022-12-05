import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Site } from '../models/site';
import { Observable } from 'rxjs';


const base_url = 'https://localhost:7247/api/v1/';
const sites_url = "FindSite/";

@Injectable({
  providedIn: 'root'
})

export class WebapiService {

  constructor( private http: HttpClient,) {}

    findAllSites()  {
      return this.http.get<Site[]>(`${base_url}${sites_url}`)
    }


}
