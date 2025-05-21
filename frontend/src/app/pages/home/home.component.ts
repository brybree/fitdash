import { Component } from '@angular/core';
import { ListGroceriesComponent } from '@components/list-groceries/list-groceries.component';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [ListGroceriesComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
