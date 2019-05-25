import { Dashboard } from "./Modules/Dashboard";
import { GridTest } from "./Modules/Test/GridTest";
import { FormTest } from "./Modules/Test/FormTest";



export const routeData = [
    { exact: false, component: GridTest, name: 'Grid Sample', path: '/grid' },
    { exact: false, component: Dashboard, name: 'Home', path: '/home' },
    { exact: false, component: FormTest, name: 'Form Sample', path: '/form' },
];
