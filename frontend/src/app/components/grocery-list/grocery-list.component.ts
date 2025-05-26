import { Component, inject } from '@angular/core';
import { Grocery } from '@app/models/Grocery.model';
import { GroceryService } from '@app/services/GroceryService';
import { Observable } from 'rxjs';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'grocery-list',
  standalone: true,
  imports: [AsyncPipe],
  templateUrl: './grocery-list.component.html',
  styleUrl: './grocery-list.component.css'
})
export class GroceryListComponent {
  grocery$!: Observable<Grocery[]>;
  
  private groceryService = inject(GroceryService);
  
  constructor() {
    this.grocery$ = this.groceryService.getGroceries();  
  }
}
