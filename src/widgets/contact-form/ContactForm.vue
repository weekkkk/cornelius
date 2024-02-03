<script lang="ts" setup></script>

<template>
  <form action="" class="contact_form f fd-col rg-4">
    <input class="contact_form-input" type="text" placeholder="Ваш телефон" />
    <input class="contact_form-input" type="text" placeholder="Ваше имя" />
    <input class="contact_form-input" type="text" placeholder="Ваше сообщение" />
    <button>Отправить</button>
  </form>
</template>

<style lang="scss" scoped>
.contact_form {
  &-input {
    border: 1px solid var(--n-second-50);
    outline: none;
    padding: 1rem;
    text-align: center;
    font-family: inherit;
    transition: 0.2s ease-in-out;
    &:focus {
      border-color: var(--n-brand);
    }
  }
}
</style>
