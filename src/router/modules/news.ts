import type { RouteRecordRaw } from 'vue-router';
import { NEWS } from './names';
/**
 * * Новости
 */
const News: RouteRecordRaw = {
  name: NEWS,
  path: NEWS,
  meta: { Title: 'Новости' },
  component: () => import('@/pages/news-page.vue'),
};
export default News;
