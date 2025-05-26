import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Grocerie } from "@app/models/Grocerie.model";
import { Observable } from "rxjs";

@Injectable({providedIn: 'root'})

export class GroceriesService {
  private http = inject(HttpClient);

  getGrocerie(id: string): Observable<Grocerie> {
    return this.http.get<Grocerie>(`/api/groceries/${id}`);
  }

  getGroceries(): Observable<[Grocerie]> {
    return this.http.get<[Grocerie]>(`/api/groceries`);
  } 
}