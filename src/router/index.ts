import {
  createRouter,
  createWebHistory,
  type RouteRecordRaw,
} from 'vue-router';
import { Main, Equipment, Design, News, Order, Contacts } from './modules';
import { MAIN } from './modules/names';

const routes: Array<RouteRecordRaw> = [
  {
    name: '',
    path: '',
    component: () => import('@/layouts/default-layout.vue'),
    redirect: { name: MAIN },
    children: [Main, Equipment, Design, News, Order, Contacts],
  },
];
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
});
export { routes };
export default router;

router.beforeEach(async (to, from, next) => {
  const { Title } = to.meta;
  const brand = '';
  document.title = `${brand}${Title as string}`;
  next();
});
