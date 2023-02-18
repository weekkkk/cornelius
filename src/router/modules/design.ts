import type { RouteRecordRaw } from 'vue-router';
import { DESIGN } from './names';
/**
 * * Оборудование
 */
const Design: RouteRecordRaw = {
  name: DESIGN,
  path: DESIGN,
  meta: { Title: 'Проектирование' },
  component: () => import('@/pages/design-page.vue'),
};
export default Design;
