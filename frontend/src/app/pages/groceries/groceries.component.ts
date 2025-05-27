import { Component, inject } from '@angular/core';
import { Grocery } from '@app/models/Grocery.model';
import { GroceryService } from '@app/services/GroceryService';
import { combineLatest, map, Observable, startWith } from 'rxjs';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'groceries',
  standalone: true,
  imports: [AsyncPipe, ReactiveFormsModule],
  templateUrl: './groceries.component.html',
  styleUrl: './groceries.component.css'
})
export class GroceriesComponent {
  private groceryService = inject(GroceryService);
  
  // Search input as reactive form control
  searchControl = new FormControl('');
  
  grocery$: Observable<Grocery[]> = this.groceryService.getGroceries();
    
  filterGroceries$: Observable<Grocery[]> = combineLatest([
    this.grocery$,
    this.searchControl.valueChanges.pipe(startWith('')),
  ]).pipe(
    map(([groceries, search]) => {
      if (!search) return groceries;
      return groceries.filter(g => 
        g.name.toLowerCase().includes(search.toLowerCase())
      );
    })
  );

  shoppingCart: Grocery[] = []
}
