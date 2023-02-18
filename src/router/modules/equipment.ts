import type { RouteRecordRaw } from 'vue-router';
import { EQUIPMENT } from './names';
/**
 * * Оборудование
 */
const Equipment: RouteRecordRaw = {
  name: EQUIPMENT,
  path: EQUIPMENT,
  meta: { Title: 'Оборудование' },
  component: () => import('@/pages/equipment-page.vue'),
};
export default Equipment;
