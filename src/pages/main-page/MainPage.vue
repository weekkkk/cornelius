<script lang="ts" setup>
import { EquipmentImage1, EquipmentImage2 } from '@/app'
import { ImageBlock } from '@/shared'
</script>

<template>
  <ImageBlock :src="EquipmentImage1" :l="1" :r="3" :t="5" b="end" />
  <ImageBlock :src="EquipmentImage2" :l="7" r="end" :t="3" b="end" />
</template>

<style lang="scss" scoped></style>
