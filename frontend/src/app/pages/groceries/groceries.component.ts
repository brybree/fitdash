import { Component } from '@angular/core';
import { GroceryListComponent } from '@app/components/grocery-list/grocery-list.component';

@Component({
  selector: 'app-groceries',
  standalone: true,
  imports: [GroceryListComponent],
  templateUrl: './groceries.component.html',
  styleUrl: './groceries.component.css'
})
export class GroceriesComponent {

}
