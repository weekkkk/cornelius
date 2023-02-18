import type { RouteRecordRaw } from 'vue-router';
import { MAIN } from './names';
/**
 * * Главная
 */
const Main: RouteRecordRaw = {
  name: MAIN,
  path: `/${MAIN}`,
  meta: { Title: 'Главная' },
  component: () => import('@/pages/main-page.vue'),
};
export default Main;
