import { Component } from '@angular/core';

@Component({
  selector: 'app-theme-toggle',
  standalone: true,
  template: `
    <button class="toggle-theme" (click)="toggleTheme()">
      Toggle Theme
    </button>
  `,
  styles: [`
    button {
      padding: 0.5rem 1rem;
      margin: 1rem;
      cursor: pointer;
    }
  `]
})
export class ThemeToggleComponent {
    ngOnInit() {
        const savedTheme = localStorage.getItem('theme');
        if (savedTheme) {
            const html = document.documentElement;
            // html.style.colorScheme = savedTheme;
            html.classList.add(savedTheme);
        } else {
          localStorage.setItem(
            "theme", 
            window.matchMedia('(prefers-color-scheme:dark)').matches ? "dark":"light"
          );
        }
    }

  toggleTheme() {
      const html = document.documentElement;
      if (localStorage.getItem("theme") == "dark") {
        // html.style.colorScheme = "light";
        html.classList.remove("dark");
        html.classList.add("light");
        localStorage.setItem("theme", "light");
        return;
      }
      html.classList.remove("light");
      html.classList.add("dark");
      // html.style.colorScheme = "dark";
      localStorage.setItem("theme", "dark");
  }
}
