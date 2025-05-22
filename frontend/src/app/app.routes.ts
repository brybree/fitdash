import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: '',
        title: 'Home',
        loadComponent: () => import('@pages/home/home.component').then(c => c.HomeComponent)
    },
    {
        path: 'programs',
        title: 'Programs',
        loadComponent: () => import('@pages/programs/programs.component').then(c => c.ProgramsComponent)
    },
    {
        path: 'groceries',
        title: 'Groceries',
        loadComponent: () => import('@pages/groceries/groceries.component').then(c => c.GroceriesComponent)
    },
    {
        path: 'training',
        title: 'Training',
        loadComponent: () => import('@pages/training/training.component').then(c => c.TrainingComponent)
    },
    {
        path: 'progress',
        title: 'Progress',
        loadComponent: () => import('@pages/progress/progress.component').then(c => c.ProgressComponent)
    },
    {
        path: 'color-test',
        title: 'Testing Color',
        loadComponent: () => import('@pages/color-test/color-test.component').then(c => c.ColorTestComponent)
    }
];
