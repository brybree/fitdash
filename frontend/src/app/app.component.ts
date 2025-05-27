import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SidenavComponent } from '@components/sidenav/sidenav.component';
import { DatePipe } from '@angular/common';
import { ThemeToggleComponent } from '@components/theme-toggle/theme-toggle.component';

@Component({
  selector: 'root',
  standalone: true,
  imports: [RouterOutlet, SidenavComponent, DatePipe, ThemeToggleComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  today: number = Date.now();
}
