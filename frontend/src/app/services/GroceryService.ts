import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Grocery } from "@app/models/Grocery.model";
import { Observable } from "rxjs";

@Injectable({providedIn: 'root'})

export class GroceryService {
  private http = inject(HttpClient);

  getGrocery(id: string): Observable<Grocery> {
    return this.http.get<Grocery>(`/groceries/${id}`);
  }

  getGroceries(): Observable<Grocery[]> {
    return this.http.get<Grocery[]>(`/groceries`);
  } 
}